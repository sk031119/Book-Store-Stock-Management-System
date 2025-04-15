namespace Book_Store_Stock_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            tabControl = new TabControl();
            tabBooks = new TabPage();
            tabAuthors = new TabPage();
            tabCategory = new TabPage();
            tabPublishers = new TabPage();
            tabReports = new TabPage();
            tabUsers = new TabPage();
            lblWelcome = new Label();
            buttonLogout = new Button();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabBooks);
            tabControl.Controls.Add(tabAuthors);
            tabControl.Controls.Add(tabCategory);
            tabControl.Controls.Add(tabPublishers);
            tabControl.Controls.Add(tabReports);
            tabControl.Controls.Add(tabUsers);
            tabControl.Location = new Point(10, 11);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(851, 462);
            tabControl.TabIndex = 0;
            // 
            // tabBooks
            // 
            tabBooks.Location = new Point(4, 24);
            tabBooks.Name = "tabBooks";
            tabBooks.Padding = new Padding(3);
            tabBooks.Size = new Size(843, 434);
            tabBooks.TabIndex = 0;
            tabBooks.Text = "Books";
            tabBooks.UseVisualStyleBackColor = true;
            // 
            // tabAuthors
            // 
            tabAuthors.Location = new Point(4, 24);
            tabAuthors.Name = "tabAuthors";
            tabAuthors.Padding = new Padding(3);
            tabAuthors.Size = new Size(843, 434);
            tabAuthors.TabIndex = 1;
            tabAuthors.Text = "Authors";
            tabAuthors.UseVisualStyleBackColor = true;
            // 
            // tabCategory
            // 
            tabCategory.Location = new Point(4, 24);
            tabCategory.Name = "tabCategory";
            tabCategory.Size = new Size(843, 434);
            tabCategory.TabIndex = 2;
            tabCategory.Text = "Categories";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // tabPublishers
            // 
            tabPublishers.Location = new Point(4, 24);
            tabPublishers.Name = "tabPublishers";
            tabPublishers.Size = new Size(843, 434);
            tabPublishers.TabIndex = 3;
            tabPublishers.Text = "Publishers";
            tabPublishers.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            tabReports.Location = new Point(4, 24);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(843, 434);
            tabReports.TabIndex = 5;
            tabReports.Text = "Reports";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Size = new Size(843, 434);
            tabUsers.TabIndex = 6;
            tabUsers.Text = "System Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWelcome.Location = new Point(627, 11);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.No;
            lblWelcome.Size = new Size(106, 15);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Admin!";
            lblWelcome.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(763, 6);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 24);
            buttonLogout.TabIndex = 2;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 486);
            Controls.Add(buttonLogout);
            Controls.Add(lblWelcome);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Stock Management System";
            FormClosed += Dashboard_FormClosed;
            Load += Dashboard_Load;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabAuthors;
        private TabPage tabCategory;
        private TabPage tabPublishers;
        private TabPage tabReports;
        private Label lblWelcome;
        private TabPage tabUsers;
        private TabPage tabBooks;
        private Button buttonLogout;
    }
}