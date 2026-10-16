namespace BookLibrary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxSearchAuthors = new TextBox();
            btnDeleteAuthor = new Button();
            btnEditAuthor = new Button();
            btnAddAuthor = new Button();
            dataGridViewAuthor = new DataGridView();
            tabPage2 = new TabPage();
            textBoxSearchBooks = new TextBox();
            dataGridViewBook = new DataGridView();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnAddBook = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 320);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxSearchAuthors);
            tabPage1.Controls.Add(btnDeleteAuthor);
            tabPage1.Controls.Add(btnEditAuthor);
            tabPage1.Controls.Add(btnAddAuthor);
            tabPage1.Controls.Add(dataGridViewAuthor);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(671, 292);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Authors";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchAuthors
            // 
            textBoxSearchAuthors.Location = new Point(3, 0);
            textBoxSearchAuthors.Name = "textBoxSearchAuthors";
            textBoxSearchAuthors.PlaceholderText = "Поиск автора по имени или фамилии...";
            textBoxSearchAuthors.Size = new Size(664, 23);
            textBoxSearchAuthors.TabIndex = 4;
            textBoxSearchAuthors.TextChanged += textBoxSearchAuthors_TextChanged;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(214, 248);
            btnDeleteAuthor.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(101, 22);
            btnDeleteAuthor.TabIndex = 3;
            btnDeleteAuthor.Text = "Delete author";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // btnEditAuthor
            // 
            btnEditAuthor.Location = new Point(116, 248);
            btnEditAuthor.Margin = new Padding(3, 2, 3, 2);
            btnEditAuthor.Name = "btnEditAuthor";
            btnEditAuthor.Size = new Size(82, 22);
            btnEditAuthor.TabIndex = 2;
            btnEditAuthor.Text = "Edit author";
            btnEditAuthor.UseVisualStyleBackColor = true;
            btnEditAuthor.Click += btnEditAuthor_Click;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(15, 248);
            btnAddAuthor.Margin = new Padding(3, 2, 3, 2);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(82, 22);
            btnAddAuthor.TabIndex = 1;
            btnAddAuthor.Text = "Add author";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // dataGridViewAuthor
            // 
            dataGridViewAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthor.Location = new Point(3, 21);
            dataGridViewAuthor.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAuthor.Name = "dataGridViewAuthor";
            dataGridViewAuthor.RowHeadersWidth = 51;
            dataGridViewAuthor.Size = new Size(664, 215);
            dataGridViewAuthor.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxSearchBooks);
            tabPage2.Controls.Add(dataGridViewBook);
            tabPage2.Controls.Add(btnDeleteBook);
            tabPage2.Controls.Add(btnUpdateBook);
            tabPage2.Controls.Add(btnAddBook);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(671, 292);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Books";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchBooks
            // 
            textBoxSearchBooks.Location = new Point(4, 0);
            textBoxSearchBooks.Name = "textBoxSearchBooks";
            textBoxSearchBooks.PlaceholderText = "Поиск книги по названию...";
            textBoxSearchBooks.Size = new Size(664, 23);
            textBoxSearchBooks.TabIndex = 6;
            textBoxSearchBooks.TextChanged += textBoxSearchBooks_TextChanged;
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Location = new Point(3, 23);
            dataGridViewBook.Margin = new Padding(3, 2, 3, 2);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.RowHeadersWidth = 51;
            dataGridViewBook.Size = new Size(664, 233);
            dataGridViewBook.TabIndex = 5;
            dataGridViewBook.ColumnHeaderMouseClick += dataGridViewBook_ColumnHeaderMouseClick;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(264, 261);
            btnDeleteBook.Margin = new Padding(3, 2, 3, 2);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(98, 22);
            btnDeleteBook.TabIndex = 4;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(136, 261);
            btnUpdateBook.Margin = new Padding(3, 2, 3, 2);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(99, 22);
            btnUpdateBook.TabIndex = 3;
            btnUpdateBook.Text = "Update book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(20, 261);
            btnAddBook.Margin = new Padding(3, 2, 3, 2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(82, 22);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnDeleteAuthor;
        private Button btnEditAuthor;
        private Button btnAddAuthor;
        private DataGridView dataGridViewAuthor;
        private TabPage tabPage2;
        private DataGridView dataGridViewBook;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnAddBook;
        private TextBox textBoxSearchBooks;
        private TextBox textBoxSearchAuthors;
    }
}
