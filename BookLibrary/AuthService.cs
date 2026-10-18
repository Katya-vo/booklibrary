
using System;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Models;

public class AuthService
{
    public string HashPassword(string password)
    {
        const int iterations = 100_000;

        byte[] salt = RandomNumberGenerator.GetBytes(16);

        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            salt,
            iterations,
            HashAlgorithmName.SHA256,
            32);

        return $"PBKDF2${iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
    }

    public bool VerifyPassword(string password, string storedHash)
    {
        try
        {
            string[] parts = storedHash.Split('$');

            if (parts.Length != 4 || parts[0] != "PBKDF2")
                return false;

            if (!int.TryParse(parts[1], out int iterations) ||
                iterations < 100_000 || iterations > 1_000_000)
                return false;

            byte[] salt = Convert.FromBase64String(parts[2]);
            byte[] expectedHash = Convert.FromBase64String(parts[3]);

            if (salt.Length != 16 || expectedHash.Length != 32)
                return false;

            byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256,
                32);

            return CryptographicOperations.FixedTimeEquals(
                actualHash, expectedHash);
        }
        catch (FormatException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }
    }

    public string Register(
        string name,
        string username,
        string password,
        string confirmPassword)
    {
        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrEmpty(password) ||
            string.IsNullOrEmpty(confirmPassword))
        {
            return "Заполните все обязательные поля.";
        }

        name = name.Trim();
        username = username.Trim();

        if (username.Length < 3)
            return "Логин должен содержать минимум 3 символа.";

        if (password.Length < 6)
            return "Пароль должен содержать минимум 6 символов.";

        if (password != confirmPassword)
            return "Пароли не совпадают.";

        try
        {
            using var db = new BookLibraryContext();

            bool exists = db.Clients.Any(
                c => c.username == username);

            if (exists)
                return "Пользователь с таким логином уже существует.";

            var client = new Client
            {
                name = name,
                username = username,
                password = HashPassword(password),
                bookId = null,
                borrowUntil = null
            };

            db.Clients.Add(client);
            db.SaveChanges();

            return "Регистрация прошла успешно!";
        }
        catch (DbUpdateException)
        {
            return "Не удалось сохранить пользователя.";
        }
        catch (Exception)
        {
            return "Не удалось выполнить регистрацию.";
        }
    }

    public bool Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrEmpty(password))
        {
            return false;
        }

        try
        {
            using var db = new BookLibraryContext();

            var client = db.Clients.FirstOrDefault(
                c => c.username == username.Trim());

            if (client == null)
                return false;

            return VerifyPassword(password, client.password);
        }
        catch (Exception)
        {
            return false;
        }
    }
}
