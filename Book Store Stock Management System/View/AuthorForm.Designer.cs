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
            lblFName.Location = new Point(12, 15);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(88, 19);
            lblFName.TabIndex = 0;
            lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(12, 55);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(86, 19);
            lblLName.TabIndex = 1;
            lblLName.Text = "Last Name:";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(96, 12);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(200, 27);
            txtFName.TabIndex = 2;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(96, 52);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(200, 27);
            txtLName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(96, 95);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(221, 95);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 136);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
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