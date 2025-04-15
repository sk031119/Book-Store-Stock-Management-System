namespace Book_Store_Stock_Management_System.View
{
    partial class UsersTab
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
            columnId = new ColumnHeader();
            columnName = new ColumnHeader();
            columnRole = new ColumnHeader();
            buttonChangePass = new Button();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(363, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 23);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // buttonSeach
            // 
            buttonSeach.Location = new Point(237, 17);
            buttonSeach.Name = "buttonSeach";
            buttonSeach.Size = new Size(75, 23);
            buttonSeach.TabIndex = 29;
            buttonSeach.Text = "Search";
            buttonSeach.UseVisualStyleBackColor = true;
            buttonSeach.Click += buttonSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(14, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(66, 15);
            lblSearch.TabIndex = 28;
            lblSearch.Text = "Username:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(86, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(128, 23);
            txtSearch.TabIndex = 27;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(108, 388);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(95, 23);
            buttonUpdate.TabIndex = 26;
            buttonUpdate.Text = "Edit User";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(14, 388);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Add User";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listVwBooks
            // 
            listVwBooks.Columns.AddRange(new ColumnHeader[] { columnId, columnName, columnRole });
            listVwBooks.FullRowSelect = true;
            listVwBooks.GridLines = true;
            listVwBooks.Location = new Point(14, 57);
            listVwBooks.Name = "listVwBooks";
            listVwBooks.Size = new Size(795, 314);
            listVwBooks.Sorting = SortOrder.Ascending;
            listVwBooks.TabIndex = 24;
            listVwBooks.UseCompatibleStateImageBehavior = false;
            listVwBooks.View = System.Windows.Forms.View.Details;
            listVwBooks.DoubleClick += buttonUpdate_Click;
            // 
            // columnId
            // 
            columnId.Text = "User ID";
            columnId.Width = 120;
            // 
            // columnName
            // 
            columnName.Text = "Username";
            columnName.Width = 120;
            // 
            // columnRole
            // 
            columnRole.Text = "Role";
            columnRole.Width = 120;
            // 
            // buttonChangePass
            // 
            buttonChangePass.Location = new Point(218, 388);
            buttonChangePass.Name = "buttonChangePass";
            buttonChangePass.Size = new Size(129, 23);
            buttonChangePass.TabIndex = 31;
            buttonChangePass.Text = "Change Password";
            buttonChangePass.UseVisualStyleBackColor = true;
            buttonChangePass.Click += buttonChangePass_Click;
            // 
            // UsersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonChangePass);
            Controls.Add(btnDelete);
            Controls.Add(buttonSeach);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(listVwBooks);
            Name = "UsersTab";
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
        private ColumnHeader columnId;
        private ColumnHeader columnName;
        private ColumnHeader columnRole;
        private Button buttonChangePass;
    }
}
