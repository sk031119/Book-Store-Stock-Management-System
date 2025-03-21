namespace Book_Store_Stock_Management_System
{
    partial class LoginForm
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
            label1.Location = new Point(58, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(131, 43);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(163, 23);
            txtUserName.TabIndex = 2;
            // 
            // maskedTxtPassword
            // 
            maskedTxtPassword.Location = new Point(131, 87);
            maskedTxtPassword.Margin = new Padding(2);
            maskedTxtPassword.Name = "maskedTxtPassword";
            maskedTxtPassword.PasswordChar = '*';
            maskedTxtPassword.Size = new Size(163, 23);
            maskedTxtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 174);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "login status:";
            // 
            // loginStatusLabel
            // 
            loginStatusLabel.AutoSize = true;
            loginStatusLabel.Location = new Point(131, 174);
            loginStatusLabel.Margin = new Padding(2, 0, 2, 0);
            loginStatusLabel.Name = "loginStatusLabel";
            loginStatusLabel.Size = new Size(68, 15);
            loginStatusLabel.TabIndex = 5;
            loginStatusLabel.Text = "Logged out";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(131, 133);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(73, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(221, 133);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(73, 23);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log&out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 229);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(loginStatusLabel);
            Controls.Add(label3);
            Controls.Add(maskedTxtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "LoginForm";
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
