namespace Book_Store_Stock_Management_System.View
{
    partial class UserForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textId = new TextBox();
            textUsername = new TextBox();
            comboRole = new ComboBox();
            buttonClear = new Button();
            buttonSave = new Button();
            label4 = new Label();
            textPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "User ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 76);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 116);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Role:";
            // 
            // textId
            // 
            textId.Enabled = false;
            textId.Location = new Point(139, 32);
            textId.Name = "textId";
            textId.Size = new Size(121, 23);
            textId.TabIndex = 3;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(139, 73);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(121, 23);
            textUsername.TabIndex = 4;
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(139, 113);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(121, 23);
            comboRole.TabIndex = 5;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(60, 203);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(167, 203);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 154);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Password:";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(139, 151);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(121, 23);
            textPassword.TabIndex = 9;
            textPassword.UseSystemPasswordChar = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 268);
            Controls.Add(textPassword);
            Controls.Add(label4);
            Controls.Add(buttonSave);
            Controls.Add(buttonClear);
            Controls.Add(comboRole);
            Controls.Add(textUsername);
            Controls.Add(textId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "Users";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textId;
        private TextBox textUsername;
        private ComboBox comboRole;
        private Button buttonClear;
        private Button buttonSave;
        private Label label4;
        private TextBox textPassword;
    }
}