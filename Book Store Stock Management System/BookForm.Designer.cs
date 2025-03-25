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
            comboCategory = new ComboBox();
            comboPublisher = new ComboBox();
            comboAuthor = new ComboBox();
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
            txtPrice = new NumericUpDown();
            txtCount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCount).BeginInit();
            SuspendLayout();
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(248, 182);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "Clear All";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(329, 129);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(121, 23);
            comboStatus.TabIndex = 8;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(329, 22);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(121, 23);
            comboCategory.TabIndex = 5;
            // 
            // comboPublisher
            // 
            comboPublisher.FormattingEnabled = true;
            comboPublisher.Location = new Point(329, 92);
            comboPublisher.Name = "comboPublisher";
            comboPublisher.Size = new Size(121, 23);
            comboPublisher.TabIndex = 7;
            // 
            // comboAuthor
            // 
            comboAuthor.FormattingEnabled = true;
            comboAuthor.Location = new Point(329, 55);
            comboAuthor.Name = "comboAuthor";
            comboAuthor.Size = new Size(121, 23);
            comboAuthor.TabIndex = 6;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(107, 22);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(118, 23);
            txtISBN.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(107, 55);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(118, 23);
            txtTitle.TabIndex = 1;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(24, 132);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(75, 15);
            labelCount.TabIndex = 6;
            labelCount.Text = "Stock Count:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(248, 132);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(74, 15);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Stock Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 58);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 25);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "ISBN:";
            // 
            // labeCategory
            // 
            labeCategory.AutoSize = true;
            labeCategory.Location = new Point(248, 25);
            labeCategory.Name = "labeCategory";
            labeCategory.Size = new Size(58, 15);
            labeCategory.TabIndex = 5;
            labeCategory.Text = "Category:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(248, 58);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(47, 15);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Author:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(248, 95);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(59, 15);
            labelPublisher.TabIndex = 4;
            labelPublisher.Text = "Publisher:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(24, 95);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(36, 15);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(137, 182);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            buttonSave.Enter += buttonSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.DecimalPlaces = 2;
            txtPrice.Location = new Point(107, 95);
            txtPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(118, 23);
            txtPrice.TabIndex = 11;
            txtPrice.ThousandsSeparator = true;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(107, 130);
            txtCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(118, 23);
            txtCount.TabIndex = 12;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 240);
            Controls.Add(txtCount);
            Controls.Add(txtPrice);
            Controls.Add(buttonSave);
            Controls.Add(buttonClear);
            Controls.Add(comboStatus);
            Controls.Add(label1);
            Controls.Add(comboCategory);
            Controls.Add(comboPublisher);
            Controls.Add(comboAuthor);
            Controls.Add(labelPrice);
            Controls.Add(labelStatus);
            Controls.Add(label2);
            Controls.Add(labeCategory);
            Controls.Add(labelCount);
            Controls.Add(labelAuthor);
            Controls.Add(txtTitle);
            Controls.Add(labelPublisher);
            Controls.Add(txtISBN);
            Name = "BookForm";
            Text = "Book";
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonClear;
        private ComboBox comboStatus;
        private ComboBox comboCategory;
        private ComboBox comboPublisher;
        private ComboBox comboAuthor;
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
        private NumericUpDown txtPrice;
        private NumericUpDown txtCount;
    }
}