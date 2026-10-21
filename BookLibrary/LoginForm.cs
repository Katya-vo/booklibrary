using System;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "admin")
            {
                // Заходить в панель адміна без справжнього аккаунту. Тест.
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                // Заходить в каталог книг без справжнього аккаунту. Тест.
                CatalogueForm catalogueForm = new CatalogueForm();
                catalogueForm.Show();
                this.Hide();
            }
        }

        private void linkCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide();
        }
    }
}
