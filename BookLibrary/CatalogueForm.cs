using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class CatalogueForm : Form
    {
        public CatalogueForm()
        {
            InitializeComponent();
        }

        private void btnTakeBook_Click(object sender, EventArgs e)
        {
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Повертає користувача на форму входу. Тест.
            LoginForm loginForm = Application.OpenForms["LoginForm"] as LoginForm;
            loginForm.Show();
            this.Close();
        }

    }
}
