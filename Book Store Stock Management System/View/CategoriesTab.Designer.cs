namespace Book_Store_Stock_Management_System
{
    partial class CategoriesTab
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
            buttonSearch = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            listViewCategory = new ListView();
            columnCategoryId = new ColumnHeader();
            columnCatName = new ColumnHeader();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(238, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 23);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete Category";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(204, 13);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 29;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 28;
            lblSearch.Text = "Name:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(55, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(128, 23);
            txtSearch.TabIndex = 27;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(118, 383);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(114, 23);
            buttonUpdate.TabIndex = 26;
            buttonUpdate.Text = "Update Category";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(13, 383);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(88, 23);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Add Category";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listViewCategory
            // 
            listViewCategory.Columns.AddRange(new ColumnHeader[] { columnCategoryId, columnCatName });
            listViewCategory.FullRowSelect = true;
            listViewCategory.GridLines = true;
            listViewCategory.Location = new Point(13, 52);
            listViewCategory.Name = "listViewCategory";
            listViewCategory.Size = new Size(795, 314);
            listViewCategory.Sorting = SortOrder.Ascending;
            listViewCategory.TabIndex = 24;
            listViewCategory.UseCompatibleStateImageBehavior = false;
            listViewCategory.View = View.Details;
            // 
            // columnCategoryId
            // 
            columnCategoryId.Text = "Category ID";
            columnCategoryId.Width = 200;
            // 
            // columnCatName
            // 
            columnCatName.Text = "Category Name";
            columnCatName.Width = 200;
            // 
            // CategoriesTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(buttonSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(listViewCategory);
            Name = "CategoriesTab";
            Size = new Size(822, 428);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button buttonSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button buttonUpdate;
        private Button buttonAdd;
        private ListView listViewCategory;
        private ColumnHeader columnCategoryId;
        private ColumnHeader columnCatName;
    }
}
