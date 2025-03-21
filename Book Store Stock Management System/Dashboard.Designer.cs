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
            tabControl = new TabControl();
            tabAuthors = new TabPage();
            tabCategory = new TabPage();
            tabPublishers = new TabPage();
            tabReports = new TabPage();
            tabEmployees = new TabPage();
            lblWelcome = new Label();
            tabBooks = new TabPage();
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
            tabControl.Controls.Add(tabEmployees);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(851, 462);
            tabControl.TabIndex = 0;
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
            // tabEmployees
            // 
            tabEmployees.Location = new Point(4, 24);
            tabEmployees.Name = "tabEmployees";
            tabEmployees.Size = new Size(843, 434);
            tabEmployees.TabIndex = 6;
            tabEmployees.Text = "Employees";
            tabEmployees.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWelcome.Location = new Point(749, 11);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.No;
            lblWelcome.Size = new Size(106, 15);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Admin!";
            lblWelcome.TextAlign = ContentAlignment.TopRight;
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 486);
            Controls.Add(lblWelcome);
            Controls.Add(tabControl);
            Name = "Dashboard";
            Text = "Stock Management System";
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
        private TabPage tabEmployees;
        private TabPage tabBooks;
    }
}