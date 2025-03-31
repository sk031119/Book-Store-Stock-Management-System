namespace Book_Store_Stock_Management_System
{
    partial class PublisherTab
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
            listViewPublishers = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderAddress = new ColumnHeader();
            columnHeaderPhone = new ColumnHeader();
            columnHeaderContactPerson = new ColumnHeader();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(275, 484);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete Publisher";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(258, 15);
            buttonSearch.Margin = new Padding(4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(96, 29);
            buttonSearch.TabIndex = 22;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 19);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 19);
            lblSearch.TabIndex = 21;
            lblSearch.Text = "Name: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(67, 15);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 27);
            txtSearch.TabIndex = 20;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(134, 484);
            buttonUpdate.Margin = new Padding(4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(122, 29);
            buttonUpdate.TabIndex = 19;
            buttonUpdate.Text = "Update Publisher";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(13, 484);
            buttonAdd.Margin = new Padding(4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(96, 29);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Add Publisher";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listViewPublishers
            // 
            listViewPublishers.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderAddress, columnHeaderPhone, columnHeaderContactPerson });
            listViewPublishers.FullRowSelect = true;
            listViewPublishers.GridLines = true;
            listViewPublishers.Location = new Point(13, 65);
            listViewPublishers.Margin = new Padding(4);
            listViewPublishers.Name = "listViewPublishers";
            listViewPublishers.Size = new Size(1021, 397);
            listViewPublishers.Sorting = SortOrder.Ascending;
            listViewPublishers.TabIndex = 17;
            listViewPublishers.UseCompatibleStateImageBehavior = false;
            listViewPublishers.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 150;
            // 
            // columnHeaderAddress
            // 
            columnHeaderAddress.Text = "Address";
            columnHeaderAddress.Width = 180;
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.Text = "Phone";
            columnHeaderPhone.Width = 120;
            // 
            // columnHeaderContactPerson
            // 
            columnHeaderContactPerson.Text = "Contact Person";
            columnHeaderContactPerson.Width = 150;
            // 
            // PublisherTab
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(buttonSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(listViewPublishers);
            Margin = new Padding(4);
            Name = "PublisherTab";
            Size = new Size(1057, 542);
            Load += PublisherTab_Load;
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
        private ListView listViewPublishers;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderAddress;
        private ColumnHeader columnHeaderPhone;
        private ColumnHeader columnHeaderContactPerson;
    }
}