namespace BookLibrary
{
    partial class AdminForm
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
            lblTitle = new Label();
            tabPage2 = new TabPage();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPageBooks = new TabPage();
            btnDeleteAuthor = new Button();
            btnEditAuthor = new Button();
            btnAddAuthor = new Button();
            dataGridViewAuthor = new DataGridView();
            tabControl1 = new TabControl();
            lblUsername = new Label();
            linkLogout = new LinkLabel();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(6, 10);
            lblTitle.Margin = new Padding(3, 0, 3, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(205, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "База даних книг";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(655, 333);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Історія";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 10);
            label1.Margin = new Padding(3, 0, 3, 16);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 5;
            label1.Text = "Історія видачі";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 60);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(643, 269);
            dataGridView1.TabIndex = 4;
            // 
            // tabPageBooks
            // 
            tabPageBooks.Controls.Add(lblTitle);
            tabPageBooks.Controls.Add(btnDeleteAuthor);
            tabPageBooks.Controls.Add(btnEditAuthor);
            tabPageBooks.Controls.Add(btnAddAuthor);
            tabPageBooks.Controls.Add(dataGridViewAuthor);
            tabPageBooks.Location = new Point(4, 24);
            tabPageBooks.Margin = new Padding(3, 2, 3, 2);
            tabPageBooks.Name = "tabPageBooks";
            tabPageBooks.Padding = new Padding(3, 2, 3, 2);
            tabPageBooks.Size = new Size(655, 333);
            tabPageBooks.TabIndex = 0;
            tabPageBooks.Text = "Книги";
            tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.BackColor = Color.Teal;
            btnDeleteAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteAuthor.ForeColor = Color.White;
            btnDeleteAuthor.Location = new Point(250, 293);
            btnDeleteAuthor.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(116, 35);
            btnDeleteAuthor.TabIndex = 3;
            btnDeleteAuthor.Text = "Видалити";
            btnDeleteAuthor.UseVisualStyleBackColor = false;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // btnEditAuthor
            // 
            btnEditAuthor.BackColor = Color.Teal;
            btnEditAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditAuthor.ForeColor = Color.White;
            btnEditAuthor.Location = new Point(128, 293);
            btnEditAuthor.Margin = new Padding(3, 2, 3, 2);
            btnEditAuthor.Name = "btnEditAuthor";
            btnEditAuthor.Size = new Size(116, 35);
            btnEditAuthor.TabIndex = 2;
            btnEditAuthor.Text = "Змінити";
            btnEditAuthor.UseVisualStyleBackColor = false;
            btnEditAuthor.Click += btnEditAuthor_Click;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.BackColor = Color.Teal;
            btnAddAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddAuthor.ForeColor = Color.White;
            btnAddAuthor.Location = new Point(6, 293);
            btnAddAuthor.Margin = new Padding(3, 2, 3, 2);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(116, 35);
            btnAddAuthor.TabIndex = 1;
            btnAddAuthor.Text = "Додати";
            btnAddAuthor.UseVisualStyleBackColor = false;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // dataGridViewAuthor
            // 
            dataGridViewAuthor.BackgroundColor = SystemColors.ControlLight;
            dataGridViewAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthor.Location = new Point(6, 60);
            dataGridViewAuthor.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAuthor.Name = "dataGridViewAuthor";
            dataGridViewAuthor.RowHeadersWidth = 51;
            dataGridViewAuthor.Size = new Size(643, 229);
            dataGridViewAuthor.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(tabPageBooks);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 36);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(663, 361);
            tabControl1.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(545, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 15);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "lblUsername";
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.LinkColor = Color.Teal;
            linkLogout.Location = new Point(633, 9);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(40, 15);
            linkLogout.TabIndex = 9;
            linkLogout.TabStop = true;
            linkLogout.Text = "Вийти";
            linkLogout.LinkClicked += this.linkLogout_LinkClicked;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(685, 409);
            Controls.Add(lblUsername);
            Controls.Add(linkLogout);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "Панель адміністратора";
            Load += Form3_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageBooks.ResumeLayout(false);
            tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private TabPage tabPage2;
        private TabPage tabPageBooks;
        private Button btnDeleteAuthor;
        private Button btnEditAuthor;
        private Button btnAddAuthor;
        private DataGridView dataGridViewAuthor;
        private TabControl tabControl1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label lblUsername;
        private LinkLabel linkLogout;
    }
}
