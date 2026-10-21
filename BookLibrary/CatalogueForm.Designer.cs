namespace BookLibrary
{
    partial class CatalogueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCatalogue = new DataGridView();
            btnTakeBook = new Button();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabPageCatalogue = new TabPage();
            lblTitle = new Label();
            tabPageUserBooks = new TabPage();
            label1 = new Label();
            btnReturnBook = new Button();
            dataGridViewUserBooks = new DataGridView();
            linkLogout = new LinkLabel();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCatalogue).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCatalogue.SuspendLayout();
            tabPageUserBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCatalogue
            // 
            dataGridViewCatalogue.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCatalogue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCatalogue.Location = new Point(6, 65);
            dataGridViewCatalogue.Margin = new Padding(1);
            dataGridViewCatalogue.Name = "dataGridViewCatalogue";
            dataGridViewCatalogue.RowHeadersWidth = 51;
            dataGridViewCatalogue.Size = new Size(643, 225);
            dataGridViewCatalogue.TabIndex = 1;
            // 
            // btnTakeBook
            // 
            btnTakeBook.BackColor = Color.Teal;
            btnTakeBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTakeBook.ForeColor = Color.White;
            btnTakeBook.Location = new Point(3, 293);
            btnTakeBook.Margin = new Padding(3, 2, 3, 2);
            btnTakeBook.Name = "btnTakeBook";
            btnTakeBook.Size = new Size(116, 35);
            btnTakeBook.TabIndex = 3;
            btnTakeBook.Text = "Взяти книгу";
            btnTakeBook.UseVisualStyleBackColor = false;
            btnTakeBook.Click += btnTakeBook_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Location = new Point(515, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Пошук за назвою...";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCatalogue);
            tabControl1.Controls.Add(tabPageUserBooks);
            tabControl1.Location = new Point(11, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(663, 361);
            tabControl1.TabIndex = 6;
            // 
            // tabPageCatalogue
            // 
            tabPageCatalogue.Controls.Add(lblTitle);
            tabPageCatalogue.Controls.Add(textBox1);
            tabPageCatalogue.Controls.Add(btnTakeBook);
            tabPageCatalogue.Controls.Add(dataGridViewCatalogue);
            tabPageCatalogue.Location = new Point(4, 24);
            tabPageCatalogue.Name = "tabPageCatalogue";
            tabPageCatalogue.Padding = new Padding(3);
            tabPageCatalogue.Size = new Size(655, 333);
            tabPageCatalogue.TabIndex = 1;
            tabPageCatalogue.Text = "Каталог";
            tabPageCatalogue.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(6, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Каталог книг";
            // 
            // tabPageUserBooks
            // 
            tabPageUserBooks.Controls.Add(label1);
            tabPageUserBooks.Controls.Add(btnReturnBook);
            tabPageUserBooks.Controls.Add(dataGridViewUserBooks);
            tabPageUserBooks.Location = new Point(4, 24);
            tabPageUserBooks.Name = "tabPageUserBooks";
            tabPageUserBooks.Padding = new Padding(3);
            tabPageUserBooks.Size = new Size(655, 333);
            tabPageUserBooks.TabIndex = 0;
            tabPageUserBooks.Text = "Мої книги";
            tabPageUserBooks.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(281, 32);
            label1.TabIndex = 7;
            label1.Text = "Книги у мене на руках";
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = SystemColors.Menu;
            btnReturnBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReturnBook.ForeColor = Color.Black;
            btnReturnBook.Location = new Point(6, 292);
            btnReturnBook.Margin = new Padding(3, 2, 3, 2);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(116, 35);
            btnReturnBook.TabIndex = 8;
            btnReturnBook.Text = "Повернути книгу";
            btnReturnBook.UseVisualStyleBackColor = false;
            // 
            // dataGridViewUserBooks
            // 
            dataGridViewUserBooks.BackgroundColor = SystemColors.ControlLight;
            dataGridViewUserBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserBooks.Location = new Point(6, 60);
            dataGridViewUserBooks.Margin = new Padding(1);
            dataGridViewUserBooks.Name = "dataGridViewUserBooks";
            dataGridViewUserBooks.RowHeadersWidth = 51;
            dataGridViewUserBooks.Size = new Size(643, 229);
            dataGridViewUserBooks.TabIndex = 7;
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.LinkColor = Color.Teal;
            linkLogout.Location = new Point(633, 9);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(40, 15);
            linkLogout.TabIndex = 7;
            linkLogout.TabStop = true;
            linkLogout.Text = "Вийти";
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(545, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 15);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "lblUsername";
            // 
            // CatalogueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(685, 409);
            Controls.Add(lblUsername);
            Controls.Add(linkLogout);
            Controls.Add(tabControl1);
            Name = "CatalogueForm";
            Text = "Бібліотека";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCatalogue).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCatalogue.ResumeLayout(false);
            tabPageCatalogue.PerformLayout();
            tabPageUserBooks.ResumeLayout(false);
            tabPageUserBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCatalogue;
        private Button btnTakeBook;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPageCatalogue;
        private Label lblTitle;
        private TabPage tabPageUserBooks;
        private Button btnReturnBook;
        private DataGridView dataGridViewUserBooks;
        private Label label1;
        private LinkLabel linkLogout;
        private Label lblUsername;
    }
}