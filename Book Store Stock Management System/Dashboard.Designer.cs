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
            tabBooks = new TabPage();
            btnDelete = new Button();
            buttonSeach = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            listVwBooks = new ListView();
            columnIsbn = new ColumnHeader();
            columnTitle = new ColumnHeader();
            columnCategory = new ColumnHeader();
            columnAuthor = new ColumnHeader();
            columnPublisher = new ColumnHeader();
            columnPrice = new ColumnHeader();
            columnStockCount = new ColumnHeader();
            columnStatus = new ColumnHeader();
            tabAuthors = new TabPage();
            tabCategory = new TabPage();
            tabPublishers = new TabPage();
            tabReports = new TabPage();
            tabEmployees = new TabPage();
            lblWelcome = new Label();
            tabControl.SuspendLayout();
            tabBooks.SuspendLayout();
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
            // tabBooks
            // 
            tabBooks.Controls.Add(btnDelete);
            tabBooks.Controls.Add(buttonSeach);
            tabBooks.Controls.Add(lblSearch);
            tabBooks.Controls.Add(txtSearch);
            tabBooks.Controls.Add(buttonUpdate);
            tabBooks.Controls.Add(buttonAdd);
            tabBooks.Controls.Add(listVwBooks);
            tabBooks.Location = new Point(4, 24);
            tabBooks.Name = "tabBooks";
            tabBooks.Padding = new Padding(3);
            tabBooks.Size = new Size(843, 434);
            tabBooks.TabIndex = 0;
            tabBooks.Text = "Books";
            tabBooks.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 389);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete Book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // buttonSeach
            // 
            buttonSeach.Location = new Point(207, 19);
            buttonSeach.Name = "buttonSeach";
            buttonSeach.Size = new Size(75, 23);
            buttonSeach.TabIndex = 15;
            buttonSeach.Text = "Search";
            buttonSeach.UseVisualStyleBackColor = true;
            buttonSeach.Click += buttonSeach_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(16, 22);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(36, 15);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Title: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(58, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(128, 23);
            txtSearch.TabIndex = 13;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(110, 389);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(95, 23);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update Book";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(16, 389);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add Book";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listVwBooks
            // 
            listVwBooks.Columns.AddRange(new ColumnHeader[] { columnIsbn, columnTitle, columnCategory, columnAuthor, columnPublisher, columnPrice, columnStockCount, columnStatus });
            listVwBooks.FullRowSelect = true;
            listVwBooks.GridLines = true;
            listVwBooks.Location = new Point(16, 58);
            listVwBooks.Name = "listVwBooks";
            listVwBooks.Size = new Size(795, 314);
            listVwBooks.Sorting = SortOrder.Ascending;
            listVwBooks.TabIndex = 10;
            listVwBooks.UseCompatibleStateImageBehavior = false;
            listVwBooks.View = View.Details;
            // 
            // columnIsbn
            // 
            columnIsbn.Text = "ISBN";
            columnIsbn.Width = 100;
            // 
            // columnTitle
            // 
            columnTitle.Text = "Title";
            columnTitle.Width = 100;
            // 
            // columnCategory
            // 
            columnCategory.Text = "Category";
            columnCategory.Width = 100;
            // 
            // columnAuthor
            // 
            columnAuthor.Text = "Author";
            columnAuthor.Width = 100;
            // 
            // columnPublisher
            // 
            columnPublisher.Text = "Publisher";
            columnPublisher.Width = 100;
            // 
            // columnPrice
            // 
            columnPrice.Text = "Price";
            columnPrice.Width = 100;
            // 
            // columnStockCount
            // 
            columnStockCount.Text = "Stock Count";
            columnStockCount.Width = 100;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            columnStatus.Width = 100;
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
            tabBooks.ResumeLayout(false);
            tabBooks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabBooks;
        private TabPage tabAuthors;
        private TabPage tabCategory;
        private TabPage tabPublishers;
        private TabPage tabReports;
        private Label lblWelcome;
        private TabPage tabEmployees;
        private ListView listVwBooks;
        private ColumnHeader columnIsbn;
        private ColumnHeader columnTitle;
        private ColumnHeader columnCategory;
        private ColumnHeader columnAuthor;
        private ColumnHeader columnPublisher;
        private ColumnHeader columnPrice;
        private ColumnHeader columnStockCount;
        private ColumnHeader columnStatus;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonSeach;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnDelete;
    }
}