using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new BookLibraryContext())
            {
                await context.Database.EnsureCreatedAsync();
            }
            await UpdateAuthors();
            await UpdateBooks();
        }

        private async Task UpdateBooks()
        {
            try
            {
                using (BookLibraryContext context = new BookLibraryContext())
                {
                    string search = textBoxSearchBooks.Text.Trim();

                    var query = context.Books
                        .Include(b => b.Author)
                        .AsQueryable();

                    if (search != "")
                    {
                        query = query.Where(b =>
                            b.Title.Contains(search) ||
                            b.Author.FirstName.Contains(search) ||
                            b.Author.Surname.Contains(search));
                    }

                    var books = await query
                        .OrderBy(b => b.Title)
                        .Select(b => new
                        {
                            b.Id,
                            b.Title,
                            b.Pages,
                            b.YearOfPublishing,
                            b.Price,
                            Author = b.Author.FirstName + " " + b.Author.Surname
                        })
                        .ToListAsync();

                    dataGridViewBook.DataSource = null;
                    dataGridViewBook.DataSource = books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task UpdateAuthors()
        {
            try
            {
                using (BookLibraryContext context = new BookLibraryContext())
                {
                    string search = textBoxSearchAuthors.Text.Trim();

                    var query = context.Authors.AsQueryable();

                    if (search != "")
                    {
                        query = query.Where(a =>
                            a.FirstName.Contains(search) ||
                            a.Surname.Contains(search));
                    }

                    var authors = await query
                        .OrderBy(a => a.Surname)
                        .ThenBy(a => a.FirstName)
                        .Select(a => new
                        {
                            a.Id,
                            a.FirstName,
                            a.Surname,
                            a.DateOfBirth
                        })
                        .ToListAsync();

                    dataGridViewAuthor.DataSource = null;
                    dataGridViewAuthor.DataSource = authors;
                    dataGridViewAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні БД. {ex.Message}");
            }
        }

        private async void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            AuthorForm authorForm = new AuthorForm(author);
            if (authorForm.ShowDialog() == DialogResult.OK)
            {
                using (BookLibraryContext context = new BookLibraryContext())
                {
                    var name = await context.Authors.FirstOrDefaultAsync(a => a.FirstName == author.FirstName && a.Surname == author.Surname);
                    if (name != null)
                    {
                        MessageBox.Show("Такий автор вже існує");
                        return;
                    }
                    context.Authors.Add(author);
                    await context.SaveChangesAsync();
                    await UpdateAuthors();
                }
            }
        }

        private async void btnEditAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthor.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridViewAuthor.SelectedRows[0].Cells["Id"].Value.ToString(), out int authorId))
                {
                    using (BookLibraryContext context = new BookLibraryContext())
                    {
                        Author? author = await context.Authors.FindAsync(authorId);
                        if (author != null)
                        {
                            AuthorForm authorForm = new AuthorForm(author);
                            if (authorForm.ShowDialog() == DialogResult.OK)
                            {
                                context.Entry(author).State = EntityState.Modified;
                                await context.SaveChangesAsync();
                                await UpdateAuthors();
                            }
                        }
                    }
                }
            }
        }

        private async void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthor.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridViewAuthor.SelectedRows[0].Cells["Id"].Value.ToString(), out int authorId))
                {
                    using (BookLibraryContext context = new BookLibraryContext())
                    {
                        Author? author = await context.Authors.FindAsync(authorId);
                        if (author != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Do you want to delete this author?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.OK)
                            {
                                context.Entry(author).State = EntityState.Deleted;
                                await context.SaveChangesAsync();
                                await UpdateAuthors();
                            }
                        }
                    }
                }
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            BookForm bookForm = new BookForm(book);
            using (BookLibraryContext context = new BookLibraryContext())
            {
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    var title = await context.Books.FirstOrDefaultAsync(b => b.Title == book.Title);
                    if (title != null)
                        MessageBox.Show("The book is already exists!");
                    else
                    {
                        context.Entry(book).State = EntityState.Added;
                        await context.SaveChangesAsync();
                        await UpdateBooks();
                    }
                }
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridViewBook.SelectedRows[0].Cells["Id"].Value.ToString(), out int bookId))
                {
                    using (BookLibraryContext context = new BookLibraryContext())
                    {
                        Book? book = await context.Books.FindAsync(bookId);
                        if (book != null)
                        {
                            BookForm bookForm = new BookForm(book);
                            if (bookForm.ShowDialog() == DialogResult.OK)
                            {
                                context.Entry(book).State = EntityState.Modified;
                                await context.SaveChangesAsync();
                                await UpdateBooks();
                            }
                        }
                    }
                }
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridViewBook.SelectedRows[0].Cells["Id"].Value.ToString(), out int bookId))
                {
                    using (BookLibraryContext context = new BookLibraryContext())
                    {
                        Book? book = await context.Books.FindAsync(bookId);
                        if (book != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Do you want to delete this book?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.OK)
                            {
                                context.Entry(book).State = EntityState.Deleted;
                                await context.SaveChangesAsync();
                                await UpdateBooks();
                            }
                        }
                    }
                }
            }
        }

        private void textBoxSearchBooks_TextChanged(object sender, EventArgs e)
        {
            _ = UpdateBooks();
        }

        private void textBoxSearchAuthors_TextChanged(object sender, EventArgs e)
        {
            _ = UpdateAuthors();
        }
    }
}

