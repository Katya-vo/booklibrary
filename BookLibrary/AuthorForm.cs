using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class AuthorForm : Form
    {
        Author author;
        public AuthorForm(Author author)
        {
            this.author = author;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker1.MinDate = new DateTime(1800, 1, 1);
            dateTimePicker1.MaxDate = DateTime.Today;
            SetInitialValues();

        }

        private void SetInitialValues()
        {
            txtBoxFirstName.Text = author.FirstName;
            txtBoxSurname.Text = author.Surname;
            if (author.DateOfBirth.HasValue)
            {
                dateTimePicker1.Value = author.DateOfBirth.Value;
                dateTimePicker1.Checked = true;
            }
            else
            {
                dateTimePicker1.Checked = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text) || string.IsNullOrWhiteSpace(txtBoxSurname.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.");
                return;
            }
            author.FirstName = txtBoxFirstName.Text;
            author.Surname = txtBoxSurname.Text;
            if (dateTimePicker1.Checked)
            {
                author.DateOfBirth = dateTimePicker1.Value;
            }
            else
            {
                author.DateOfBirth = null;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }




}
