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
            label1 = new Label();
            txtBoxTitle = new TextBox();
            txtBoxYear = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxPages = new TextBox();
            comboBox1 = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(21, 52);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(151, 27);
            txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxYear
            // 
            txtBoxYear.Location = new Point(21, 106);
            txtBoxYear.Name = "txtBoxYear";
            txtBoxYear.Size = new Size(151, 27);
            txtBoxYear.TabIndex = 2;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(21, 158);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(151, 27);
            txtBoxPrice.TabIndex = 3;
            // 
            // txtBoxPages
            // 
            txtBoxPages.Location = new Point(21, 212);
            txtBoxPages.Name = "txtBoxPages";
            txtBoxPages.Size = new Size(151, 27);
            txtBoxPages.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(21, 337);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 7;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(163, 337);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 9;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 136);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 10;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 189);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 11;
            label4.Text = "Pages";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 245);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 12;
            label5.Text = "Author";
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 389);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(comboBox1);
            Controls.Add(txtBoxPages);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxYear);
            Controls.Add(txtBoxTitle);
            Controls.Add(label1);
            Name = "BookForm";
            Text = "BookForm";
            Load += BookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxTitle;
        private TextBox txtBoxYear;
        private TextBox txtBoxPrice;
        private TextBox txtBoxPages;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Button btnOk;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}