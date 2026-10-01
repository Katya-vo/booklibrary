namespace BookLibrary
{
    partial class AuthorForm
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
            label1 = new Label();
            txtBoxFirstName = new TextBox();
            label2 = new Label();
            txtBoxSurname = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(21, 49);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(251, 27);
            txtBoxFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(21, 132);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(251, 27);
            txtBoxSurname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 183);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 4;
            label3.Text = "DateOfBirthday";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(22, 224);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(22, 316);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(178, 316);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 378);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtBoxSurname);
            Controls.Add(label2);
            Controls.Add(txtBoxFirstName);
            Controls.Add(label1);
            Name = "AuthorForm";
            Text = "AuthorForm";           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxFirstName;
        private Label label2;
        private TextBox txtBoxSurname;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnOk;
        private Button btnCancel;
    }
}