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
            dateTimePickerDeath = new DateTimePicker();
            txtBoxCountryOfBirth = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(18, 37);
            txtBoxFirstName.Margin = new Padding(3, 2, 3, 2);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(220, 23);
            txtBoxFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(18, 99);
            txtBoxSurname.Margin = new Padding(3, 2, 3, 2);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(220, 23);
            txtBoxSurname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 137);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "DateOfBirthday";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 168);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(19, 277);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 22);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(156, 277);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dateTimePickerDeath
            // 
            dateTimePickerDeath.Location = new Point(19, 209);
            dateTimePickerDeath.Name = "dateTimePickerDeath";
            dateTimePickerDeath.ShowCheckBox = true;
            dateTimePickerDeath.Size = new Size(200, 23);
            dateTimePickerDeath.TabIndex = 8;
            // 
            // txtBoxCountryOfBirth
            // 
            txtBoxCountryOfBirth.Location = new Point(19, 249);
            txtBoxCountryOfBirth.Name = "txtBoxCountryOfBirth";
            txtBoxCountryOfBirth.Size = new Size(200, 23);
            txtBoxCountryOfBirth.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 193);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 10;
            label4.Text = "DateOfDeath";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 233);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Country";
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 325);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBoxCountryOfBirth);
            Controls.Add(dateTimePickerDeath);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtBoxSurname);
            Controls.Add(label2);
            Controls.Add(txtBoxFirstName);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker dateTimePickerDeath;
        private TextBox txtBoxCountryOfBirth;
        private Label label4;
        private Label label5;
    }
}