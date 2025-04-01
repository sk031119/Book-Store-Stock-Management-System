namespace Book_Store_Stock_Management_System.View
{
    partial class ChangePassForm
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
            textConfirmPass = new TextBox();
            labelConfirmPass = new Label();
            textPassword = new TextBox();
            labelPass = new Label();
            buttonSave = new Button();
            buttonClear = new Button();
            textUsername = new TextBox();
            textId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textConfirmPass
            // 
            textConfirmPass.Location = new Point(176, 169);
            textConfirmPass.Name = "textConfirmPass";
            textConfirmPass.Size = new Size(121, 23);
            textConfirmPass.TabIndex = 23;
            textConfirmPass.UseSystemPasswordChar = true;
            // 
            // labelConfirmPass
            // 
            labelConfirmPass.AutoSize = true;
            labelConfirmPass.Location = new Point(43, 172);
            labelConfirmPass.Name = "labelConfirmPass";
            labelConfirmPass.Size = new Size(107, 15);
            labelConfirmPass.TabIndex = 22;
            labelConfirmPass.Text = "Confirm Password:";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(176, 126);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(121, 23);
            textPassword.TabIndex = 21;
            textPassword.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(43, 129);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(60, 15);
            labelPass.TabIndex = 20;
            labelPass.Text = "Password:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(176, 224);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += this.buttonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(69, 224);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textUsername
            // 
            textUsername.Enabled = false;
            textUsername.Location = new Point(176, 80);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(121, 23);
            textUsername.TabIndex = 16;
            // 
            // textId
            // 
            textId.Enabled = false;
            textId.Location = new Point(176, 39);
            textId.Name = "textId";
            textId.Size = new Size(121, 23);
            textId.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 13;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 42);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 12;
            label1.Text = "User ID:";
            // 
            // ChangePassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 288);
            Controls.Add(textConfirmPass);
            Controls.Add(labelConfirmPass);
            Controls.Add(textPassword);
            Controls.Add(labelPass);
            Controls.Add(buttonSave);
            Controls.Add(buttonClear);
            Controls.Add(textUsername);
            Controls.Add(textId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePassForm";
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textConfirmPass;
        private Label labelConfirmPass;
        private TextBox textPassword;
        private Label labelPass;
        private Button buttonSave;
        private Button buttonClear;
        private TextBox textUsername;
        private TextBox textId;
        private Label label2;
        private Label label1;
    }
}