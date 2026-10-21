namespace BookLibrary
{
    partial class LoginForm
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            btnLogin = new Button();
            linkCreateAcc = new LinkLabel();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(38, 41);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(119, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Увійдіть в акаунт";
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
            // textBoxLogin
            // 
            textBoxLogin.BackColor = SystemColors.Menu;
            textBoxLogin.Location = new Point(31, 75);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Логин / Email";
            textBoxLogin.Size = new Size(133, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Menu;
            textBoxPassword.Location = new Point(31, 104);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Пароль";
            textBoxPassword.Size = new Size(133, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(31, 133);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ввійти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkCreateAcc
            // 
            linkCreateAcc.AutoSize = true;
            linkCreateAcc.LinkColor = Color.Teal;
            linkCreateAcc.Location = new Point(48, 166);
            linkCreateAcc.Name = "linkCreateAcc";
            linkCreateAcc.Size = new Size(98, 15);
            linkCreateAcc.TabIndex = 5;
            linkCreateAcc.TabStop = true;
            linkCreateAcc.Text = "Створити акаунт";
            linkCreateAcc.LinkClicked += linkCreateAcc_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(194, 218);
            Controls.Add(linkCreateAcc);
            Controls.Add(btnLogin);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бібліотека";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubtitle;
        private Label lblTitle;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button btnLogin;
        private LinkLabel linkCreateAcc;
    }
}
