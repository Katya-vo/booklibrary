namespace BookLibrary
{
    partial class AccountForm
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
            textBox1 = new TextBox();
            linkLogin = new LinkLabel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnCreateAccount = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(31, 75);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ім'я";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 6;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.LinkColor = Color.Teal;
            linkLogin.Location = new Point(49, 195);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(90, 15);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Ввійти в акаунт";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(29, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Бібліотека";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(43, 41);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(109, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Створіть акаунт";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Teal;
            btnCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(31, 162);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(133, 30);
            btnCreateAccount.TabIndex = 4;
            btnCreateAccount.Text = "Створити акаунт";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Menu;
            textBoxPassword.Location = new Point(31, 133);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Пароль";
            textBoxPassword.Size = new Size(133, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = SystemColors.Menu;
            textBoxLogin.Location = new Point(31, 104);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Логин / Email";
            textBoxLogin.Size = new Size(133, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(194, 228);
            Controls.Add(textBox1);
            Controls.Add(linkLogin);
            Controls.Add(lblTitle);
            Controls.Add(textBoxLogin);
            Controls.Add(lblSubtitle);
            Controls.Add(textBoxPassword);
            Controls.Add(btnCreateAccount);
            Name = "AccountForm";
            Text = "Бібліотека";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLogin;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnCreateAccount;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBox1;
    }
}