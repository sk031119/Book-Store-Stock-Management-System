namespace Book_Store_Stock_Management_System
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            buttonSave = new Button();
            buttonClear = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(53, 117);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 27;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(157, 117);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 28;
            buttonClear.Text = "Clear All";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 71);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 11;
            label1.Text = "Category Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 38);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 13;
            label2.Text = "Category ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(118, 23);
            txtName.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(146, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 23);
            txtId.TabIndex = 12;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 183);
            Controls.Add(buttonSave);
            Controls.Add(buttonClear);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CategoryForm";
            Text = "Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button buttonSave;
        private Button buttonClear;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtId;
    }
}