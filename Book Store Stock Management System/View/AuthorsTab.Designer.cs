namespace Book_Store_Stock_Management_System
{
    partial class AuthorsTab
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
            listViewAuthors = new ListView();
            columnFName = new ColumnHeader();
            columnLName = new ColumnHeader();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(214, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete Author";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(201, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 22;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 21;
            lblSearch.Text = "Name:";
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
            buttonUpdate.Text = "Update Author";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(10, 382);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Add Author";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listViewAuthors
            // 
            listViewAuthors.Columns.AddRange(new ColumnHeader[] { columnFName, columnLName });
            listViewAuthors.FullRowSelect = true;
            listViewAuthors.GridLines = true;
            listViewAuthors.Location = new Point(10, 51);
            listViewAuthors.Name = "listViewAuthors";
            listViewAuthors.Size = new Size(795, 314);
            listViewAuthors.Sorting = SortOrder.Ascending;
            listViewAuthors.TabIndex = 17;
            listViewAuthors.UseCompatibleStateImageBehavior = false;
            listViewAuthors.View = System.Windows.Forms.View.Details;
            // 
            // columnFName
            // 
            columnFName.Text = "First Name";
            columnFName.Width = 200;
            // 
            // columnLName
            // 
            columnLName.Text = "Last Name";
            columnLName.Width = 200;
            // 
            // AuthorsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(buttonSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(listViewAuthors);
            Name = "AuthorsTab";
            Size = new Size(822, 428);
            Load += AuthorsTab_Load;
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
        private ListView listViewAuthors;
        private ColumnHeader columnFName;
        private ColumnHeader columnLName;
    }
}
