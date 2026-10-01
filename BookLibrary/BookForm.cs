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
    public partial class BookForm : Form
    {
        Book book;
        public BookForm(Book book)
        {
            this.book = book;
            InitializeComponent();
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            comboBox1.SelectedValue = book.AuthorId;
            txtBoxTitle.Text = book.Title;
            txtBoxYear.Text = book.YearOfPublishing.ToString();
            txtBoxPages.Text = book.Pages.ToString();
            txtBoxPrice.Text = book.Price.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out int id_author))
                {
                    book.AuthorId = id_author;
                }
                book.Title = txtBoxTitle.Text;
                book.YearOfPublishing = int.Parse(txtBoxYear.Text);
                book.Pages = int.Parse(txtBoxPages.Text);
                book.Price = Convert.ToDecimal(txtBoxPrice.Text);
            }
            else
            {
                MessageBox.Show("Choose author!");
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            using(BookLibraryContext context=new BookLibraryContext())
            {
                comboBox1.DataSource = null;
                comboBox1.DisplayMember = nameof(Author.Fullname);
                comboBox1.ValueMember = nameof(Author.Id);
                comboBox1.DataSource = context.Authors.ToList();
            }
        }
    }
}
