namespace Book_Store_Stock_Management_System
{
    partial class BookStockForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            maskedTxtPassword = new MaskedTextBox();
            label3 = new Label();
            loginStatusLabel = new Label();
            btnLogin = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 63);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "user name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 118);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "password :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(169, 55);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(209, 27);
            txtUserName.TabIndex = 2;
            // 
            // maskedTxtPassword
            // 
            maskedTxtPassword.Location = new Point(169, 110);
            maskedTxtPassword.Name = "maskedTxtPassword";
            maskedTxtPassword.PasswordChar = '*';
            maskedTxtPassword.Size = new Size(209, 27);
            maskedTxtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 192);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 4;
            label3.Text = "login status:";
            // 
            // loginStatusLabel
            // 
            loginStatusLabel.AutoSize = true;
            loginStatusLabel.Location = new Point(169, 192);
            loginStatusLabel.Name = "loginStatusLabel";
            loginStatusLabel.Size = new Size(91, 19);
            loginStatusLabel.TabIndex = 5;
            loginStatusLabel.Text = "Logged out";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(169, 143);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(284, 143);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log&out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // BookStockForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 876);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(loginStatusLabel);
            Controls.Add(label3);
            Controls.Add(maskedTxtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookStockForm";
            Text = "Stock Management System";
            ResumeLayout(false);
            PerformLayout();
        }


        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private MaskedTextBox maskedTxtPassword;
        private Label label3;
        private Label loginStatusLabel;
        private Button btnLogin;
        private Button btnLogout;
    }
}
