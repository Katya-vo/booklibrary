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
            txtBoxPublisher = new TextBox();
            txtBoxLanguage = new TextBox();
            txtBoxGenre = new TextBox();
            labelGenre = new Label();
            labelPublisher = new Label();
            labelLanguage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(18, 39);
            txtBoxTitle.Margin = new Padding(3, 2, 3, 2);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(133, 23);
            txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxYear
            // 
            txtBoxYear.Location = new Point(18, 80);
            txtBoxYear.Margin = new Padding(3, 2, 3, 2);
            txtBoxYear.Name = "txtBoxYear";
            txtBoxYear.Size = new Size(133, 23);
            txtBoxYear.TabIndex = 2;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(18, 118);
            txtBoxPrice.Margin = new Padding(3, 2, 3, 2);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(133, 23);
            txtBoxPrice.TabIndex = 3;
            // 
            // txtBoxPages
            // 
            txtBoxPages.Location = new Point(18, 159);
            txtBoxPages.Margin = new Padding(3, 2, 3, 2);
            txtBoxPages.Name = "txtBoxPages";
            txtBoxPages.Size = new Size(133, 23);
            txtBoxPages.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 338);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 6;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(10, 365);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 22);
            btnOk.TabIndex = 7;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(146, 365);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Pages";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 321);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 12;
            label5.Text = "Author";
            // 
            // txtBoxPublisher
            // 
            txtBoxPublisher.Location = new Point(18, 243);
            txtBoxPublisher.Margin = new Padding(3, 2, 3, 2);
            txtBoxPublisher.Name = "txtBoxPublisher";
            txtBoxPublisher.Size = new Size(133, 23);
            txtBoxPublisher.TabIndex = 13;
            // 
            // txtBoxLanguage
            // 
            txtBoxLanguage.Location = new Point(18, 296);
            txtBoxLanguage.Margin = new Padding(3, 2, 3, 2);
            txtBoxLanguage.Name = "txtBoxLanguage";
            txtBoxLanguage.Size = new Size(133, 23);
            txtBoxLanguage.TabIndex = 14;
            // 
            // txtBoxGenre
            // 
            txtBoxGenre.Location = new Point(18, 201);
            txtBoxGenre.Margin = new Padding(3, 2, 3, 2);
            txtBoxGenre.Name = "txtBoxGenre";
            txtBoxGenre.Size = new Size(133, 23);
            txtBoxGenre.TabIndex = 15;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(12, 184);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(41, 15);
            labelGenre.TabIndex = 16;
            labelGenre.Text = "Genre:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(10, 226);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(59, 15);
            labelPublisher.TabIndex = 17;
            labelPublisher.Text = "Publisher:";
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Location = new Point(10, 268);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(62, 15);
            labelLanguage.TabIndex = 18;
            labelLanguage.Text = "Language:";
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 398);
            Controls.Add(labelLanguage);
            Controls.Add(labelPublisher);
            Controls.Add(labelGenre);
            Controls.Add(txtBoxGenre);
            Controls.Add(txtBoxLanguage);
            Controls.Add(txtBoxPublisher);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtBoxGenre;
        private TextBox txtBoxPublisher;
        private TextBox txtBoxLanguage;
        private Label labelGenre;
        private Label labelPublisher;
        private Label labelLanguage;
    }
}