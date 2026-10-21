using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object? sender, EventArgs e)
        {
        }

        private void btnAddAuthor_Click(object? sender, EventArgs e)
        {
        }

        private void btnEditAuthor_Click(object? sender, EventArgs e)
        {
        }

        private void btnDeleteAuthor_Click(object? sender, EventArgs e)
        {
        }

        private void btnAddBook_Click(object? sender, EventArgs e)
        {
        }

        private void btnUpdateBook_Click(object? sender, EventArgs e)
        {
        }

        private void btnDeleteBook_Click(object? sender, EventArgs e)
        {
        }

        private void linkLogout_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            // Повертає користувача на форму входу. Тест.
            LoginForm loginForm = Application.OpenForms["LoginForm"] as LoginForm;
            loginForm.Show();
            this.Close();
        }
    }
}
