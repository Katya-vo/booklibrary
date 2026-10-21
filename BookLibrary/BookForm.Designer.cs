namespace BookLibrary
{
    partial class BookForm
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
            lblTitle = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            lblBookDesc = new Label();
            lblBookName = new Label();
            textBox1 = new TextBox();
            lblPrice = new Label();
            btnSaveBook = new Button();
            btnCancelBook = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(40, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(175, 32);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Додати книгу";
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = SystemColors.Menu;
            textBoxLastName.Location = new Point(9, 133);
            textBoxLastName.Multiline = true;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Введіть короткий опис книги...";
            textBoxLastName.Size = new Size(237, 72);
            textBoxLastName.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = SystemColors.Menu;
            textBoxFirstName.Location = new Point(9, 79);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Введіть назву...";
            textBoxFirstName.Size = new Size(237, 23);
            textBoxFirstName.TabIndex = 10;
            // 
            // lblBookDesc
            // 
            lblBookDesc.AutoSize = true;
            lblBookDesc.Location = new Point(9, 115);
            lblBookDesc.Name = "lblBookDesc";
            lblBookDesc.Size = new Size(36, 15);
            lblBookDesc.TabIndex = 9;
            lblBookDesc.Text = "Опис";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(9, 61);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(74, 15);
            lblBookName.TabIndex = 8;
            lblBookName.Text = "Назва книги";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(9, 238);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введіть ціну (грн ₴)...";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 13;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(9, 220);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Ціна";
            // 
            // btnSaveBook
            // 
            btnSaveBook.BackColor = Color.Teal;
            btnSaveBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveBook.ForeColor = Color.White;
            btnSaveBook.Location = new Point(132, 278);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(114, 38);
            btnSaveBook.TabIndex = 15;
            btnSaveBook.Text = "Зберегти";
            btnSaveBook.UseVisualStyleBackColor = false;
            btnSaveBook.Click += btnSaveBook_Click;
            // 
            // btnCancelBook
            // 
            btnCancelBook.BackColor = SystemColors.Menu;
            btnCancelBook.Location = new Point(9, 278);
            btnCancelBook.Name = "btnCancelBook";
            btnCancelBook.Size = new Size(114, 38);
            btnCancelBook.TabIndex = 14;
            btnCancelBook.Text = "Скасувати";
            btnCancelBook.UseVisualStyleBackColor = false;
            btnCancelBook.Click += btnCancelBook_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(254, 327);
            Controls.Add(btnSaveBook);
            Controls.Add(btnCancelBook);
            Controls.Add(textBox1);
            Controls.Add(lblPrice);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(lblBookDesc);
            Controls.Add(lblBookName);
            Controls.Add(lblTitle);
            Name = "BookForm";
            Text = "Панель адміністратора";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label lblBookDesc;
        private Label lblBookName;
        private TextBox textBox1;
        private Label lblPrice;
        private Button btnSaveBook;
        private Button btnCancelBook;
    }
}