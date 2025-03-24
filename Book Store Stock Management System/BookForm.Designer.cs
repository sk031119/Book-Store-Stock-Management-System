namespace Book_Store_Stock_Management_System
{
    partial class BookForm
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
            buttonClear = new Button();
            comboStatus = new ComboBox();
            txtCount = new TextBox();
            comboCategory = new ComboBox();
            comboPublisher = new ComboBox();
            comboAuthor = new ComboBox();
            txtPrice = new TextBox();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            labelCount = new Label();
            labelStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            labeCategory = new Label();
            labelAuthor = new Label();
            labelPublisher = new Label();
            labelPrice = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(319, 231);
            buttonClear.Margin = new Padding(4, 4, 4, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(96, 29);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "Clear All";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(423, 163);
            comboStatus.Margin = new Padding(4, 4, 4, 4);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(154, 27);
            comboStatus.TabIndex = 8;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(135, 163);
            txtCount.Margin = new Padding(4, 4, 4, 4);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(127, 27);
            txtCount.TabIndex = 4;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(423, 28);
            comboCategory.Margin = new Padding(4, 4, 4, 4);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(154, 27);
            comboCategory.TabIndex = 5;
            // 
            // comboPublisher
            // 
            comboPublisher.FormattingEnabled = true;
            comboPublisher.Location = new Point(423, 117);
            comboPublisher.Margin = new Padding(4, 4, 4, 4);
            comboPublisher.Name = "comboPublisher";
            comboPublisher.Size = new Size(154, 27);
            comboPublisher.TabIndex = 7;
            // 
            // comboAuthor
            // 
            comboAuthor.FormattingEnabled = true;
            comboAuthor.Location = new Point(423, 70);
            comboAuthor.Margin = new Padding(4, 4, 4, 4);
            comboAuthor.Name = "comboAuthor";
            comboAuthor.Size = new Size(154, 27);
            comboAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(138, 117);
            txtPrice.Margin = new Padding(4, 4, 4, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(127, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(138, 28);
            txtISBN.Margin = new Padding(4, 4, 4, 4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(127, 27);
            txtISBN.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(138, 70);
            txtTitle.Margin = new Padding(4, 4, 4, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(127, 27);
            txtTitle.TabIndex = 1;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(31, 167);
            labelCount.Margin = new Padding(4, 0, 4, 0);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(96, 19);
            labelCount.TabIndex = 6;
            labelCount.Text = "Stock Count:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(319, 167);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(97, 19);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Stock Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "ISBN:";
            // 
            // labeCategory
            // 
            labeCategory.AutoSize = true;
            labeCategory.Location = new Point(319, 32);
            labeCategory.Margin = new Padding(4, 0, 4, 0);
            labeCategory.Name = "labeCategory";
            labeCategory.Size = new Size(76, 19);
            labeCategory.TabIndex = 5;
            labeCategory.Text = "Category:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(319, 73);
            labelAuthor.Margin = new Padding(4, 0, 4, 0);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(60, 19);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Author:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(319, 120);
            labelPublisher.Margin = new Padding(4, 0, 4, 0);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(77, 19);
            labelPublisher.TabIndex = 4;
            labelPublisher.Text = "Publisher:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(31, 120);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(46, 19);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(176, 231);
            buttonSave.Margin = new Padding(4, 4, 4, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(96, 29);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            buttonSave.Enter += buttonSave_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 304);
            Controls.Add(buttonSave);
            Controls.Add(buttonClear);
            Controls.Add(comboStatus);
            Controls.Add(label1);
            Controls.Add(comboCategory);
            Controls.Add(comboPublisher);
            Controls.Add(txtCount);
            Controls.Add(comboAuthor);
            Controls.Add(labelPrice);
            Controls.Add(labelStatus);
            Controls.Add(label2);
            Controls.Add(labeCategory);
            Controls.Add(labelCount);
            Controls.Add(labelAuthor);
            Controls.Add(txtTitle);
            Controls.Add(labelPublisher);
            Controls.Add(txtPrice);
            Controls.Add(txtISBN);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BookForm";
            Text = "Book";
            Load += BookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonClear;
        private ComboBox comboStatus;
        private TextBox txtCount;
        private ComboBox comboCategory;
        private ComboBox comboPublisher;
        private ComboBox comboAuthor;
        private TextBox txtPrice;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private Label labelCount;
        private Label labelStatus;
        private Label label1;
        private Label label2;
        private Label labeCategory;
        private Label labelAuthor;
        private Label labelPublisher;
        private Label labelPrice;
        private Button buttonSave;
    }
}