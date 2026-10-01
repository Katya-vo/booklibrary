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
            btnDeleteAuthor = new Button();
            btnEditAuthor = new Button();
            btnAddAuthor = new Button();
            dataGridViewAuthor = new DataGridView();
            tabPage2 = new TabPage();
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
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeleteAuthor);
            tabPage1.Controls.Add(btnEditAuthor);
            tabPage1.Controls.Add(btnAddAuthor);
            tabPage1.Controls.Add(dataGridViewAuthor);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Authors";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(244, 331);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(115, 29);
            btnDeleteAuthor.TabIndex = 3;
            btnDeleteAuthor.Text = "Delete author";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // btnEditAuthor
            // 
            btnEditAuthor.Location = new Point(132, 331);
            btnEditAuthor.Name = "btnEditAuthor";
            btnEditAuthor.Size = new Size(94, 29);
            btnEditAuthor.TabIndex = 2;
            btnEditAuthor.Text = "Edit author";
            btnEditAuthor.UseVisualStyleBackColor = true;
            btnEditAuthor.Click += btnEditAuthor_Click;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(17, 331);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(94, 29);
            btnAddAuthor.TabIndex = 1;
            btnAddAuthor.Text = "Add author";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // dataGridViewAuthor
            // 
            dataGridViewAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthor.Location = new Point(3, 9);
            dataGridViewAuthor.Name = "dataGridViewAuthor";
            dataGridViewAuthor.RowHeadersWidth = 51;
            dataGridViewAuthor.Size = new Size(759, 305);
            dataGridViewAuthor.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewBook);
            tabPage2.Controls.Add(btnDeleteBook);
            tabPage2.Controls.Add(btnUpdateBook);
            tabPage2.Controls.Add(btnAddBook);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Books";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Location = new Point(3, 8);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.RowHeadersWidth = 51;
            dataGridViewBook.Size = new Size(759, 334);
            dataGridViewBook.TabIndex = 5;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(302, 348);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(112, 29);
            btnDeleteBook.TabIndex = 4;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(156, 348);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(113, 29);
            btnUpdateBook.TabIndex = 3;
            btnUpdateBook.Text = "Update book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(23, 348);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).EndInit();
            tabPage2.ResumeLayout(false);
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
    }
}
