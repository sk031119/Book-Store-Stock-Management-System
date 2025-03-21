namespace Book_Store_Stock_Management_System
{
    partial class BookTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(214, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete Book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // buttonSeach
            // 
            buttonSeach.Location = new Point(201, 12);
            buttonSeach.Name = "buttonSeach";
            buttonSeach.Size = new Size(75, 23);
            buttonSeach.TabIndex = 22;
            buttonSeach.Text = "Search";
            buttonSeach.UseVisualStyleBackColor = true;
            buttonSeach.Click += buttonSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(36, 15);
            lblSearch.TabIndex = 21;
            lblSearch.Text = "Title: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(52, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(128, 23);
            txtSearch.TabIndex = 20;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(104, 382);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(95, 23);
            buttonUpdate.TabIndex = 19;
            buttonUpdate.Text = "Update Book";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(10, 382);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Add Book";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listVwBooks
            // 
            listVwBooks.Columns.AddRange(new ColumnHeader[] { columnIsbn, columnTitle, columnCategory, columnAuthor, columnPublisher, columnPrice, columnStockCount, columnStatus });
            listVwBooks.FullRowSelect = true;
            listVwBooks.GridLines = true;
            listVwBooks.Location = new Point(10, 51);
            listVwBooks.Name = "listVwBooks";
            listVwBooks.Size = new Size(795, 314);
            listVwBooks.Sorting = SortOrder.Ascending;
            listVwBooks.TabIndex = 17;
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
            // BookTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(buttonSeach);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(listVwBooks);
            Name = "BookTab";
            Size = new Size(822, 428);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button buttonSeach;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button buttonUpdate;
        private Button buttonAdd;
        private ListView listVwBooks;
        private ColumnHeader columnIsbn;
        private ColumnHeader columnTitle;
        private ColumnHeader columnCategory;
        private ColumnHeader columnAuthor;
        private ColumnHeader columnPublisher;
        private ColumnHeader columnPrice;
        private ColumnHeader columnStockCount;
        private ColumnHeader columnStatus;
    }
}
