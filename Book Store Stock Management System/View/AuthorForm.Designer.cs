namespace Book_Store_Stock_Management_System
{
    partial class AuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorForm));
            lblFName = new Label();
            lblLName = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(9, 12);
            lblFName.Margin = new Padding(2, 0, 2, 0);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(67, 15);
            lblFName.TabIndex = 0;
            lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(9, 43);
            lblLName.Margin = new Padding(2, 0, 2, 0);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(66, 15);
            lblLName.TabIndex = 1;
            lblLName.Text = "Last Name:";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(75, 9);
            txtFName.Margin = new Padding(2, 2, 2, 2);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(156, 23);
            txtFName.TabIndex = 2;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(75, 41);
            txtLName.Margin = new Padding(2, 2, 2, 2);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(156, 23);
            txtLName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(75, 75);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(58, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(172, 75);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(58, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 107);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "AuthorForm";
            Text = "AuthorForm";
            Load += AuthorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}