namespace Book_Store_Stock_Management_System
{
    partial class MainForm
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
            tabControl = new TabControl();
            tabBooks = new TabPage();
            listBook = new ListBox();
            groupAddBook = new GroupBox();
            buttonClear = new Button();
            buttonAdd = new Button();
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
            tabAuthors = new TabPage();
            tabCategory = new TabPage();
            tabPublishers = new TabPage();
            tabStocks = new TabPage();
            tabReports = new TabPage();
            tabControl.SuspendLayout();
            tabBooks.SuspendLayout();
            groupAddBook.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabBooks);
            tabControl.Controls.Add(tabAuthors);
            tabControl.Controls.Add(tabCategory);
            tabControl.Controls.Add(tabPublishers);
            tabControl.Controls.Add(tabStocks);
            tabControl.Controls.Add(tabReports);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 462);
            tabControl.TabIndex = 0;
            // 
            // tabBooks
            // 
            tabBooks.Controls.Add(listBook);
            tabBooks.Controls.Add(groupAddBook);
            tabBooks.Location = new Point(4, 24);
            tabBooks.Name = "tabBooks";
            tabBooks.Padding = new Padding(3);
            tabBooks.Size = new Size(768, 434);
            tabBooks.TabIndex = 0;
            tabBooks.Text = "Book";
            tabBooks.UseVisualStyleBackColor = true;
            // 
            // listBook
            // 
            listBook.FormattingEnabled = true;
            listBook.HorizontalScrollbar = true;
            listBook.Location = new Point(6, 209);
            listBook.Name = "listBook";
            listBook.Size = new Size(756, 214);
            listBook.TabIndex = 9;
            // 
            // groupAddBook
            // 
            groupAddBook.Controls.Add(buttonClear);
            groupAddBook.Controls.Add(buttonAdd);
            groupAddBook.Controls.Add(comboStatus);
            groupAddBook.Controls.Add(txtCount);
            groupAddBook.Controls.Add(comboCategory);
            groupAddBook.Controls.Add(comboPublisher);
            groupAddBook.Controls.Add(comboAuthor);
            groupAddBook.Controls.Add(txtPrice);
            groupAddBook.Controls.Add(txtISBN);
            groupAddBook.Controls.Add(txtTitle);
            groupAddBook.Controls.Add(labelCount);
            groupAddBook.Controls.Add(labelStatus);
            groupAddBook.Controls.Add(label1);
            groupAddBook.Controls.Add(label2);
            groupAddBook.Controls.Add(labeCategory);
            groupAddBook.Controls.Add(labelAuthor);
            groupAddBook.Controls.Add(labelPublisher);
            groupAddBook.Controls.Add(labelPrice);
            groupAddBook.Location = new Point(6, 6);
            groupAddBook.Name = "groupAddBook";
            groupAddBook.Size = new Size(756, 188);
            groupAddBook.TabIndex = 8;
            groupAddBook.TabStop = false;
            groupAddBook.Text = "Add Book";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(644, 62);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Clear All";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(644, 111);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add Book";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(411, 136);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(121, 23);
            comboStatus.TabIndex = 8;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(97, 136);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(100, 23);
            txtCount.TabIndex = 4;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(411, 29);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(121, 23);
            comboCategory.TabIndex = 5;
            // 
            // comboPublisher
            // 
            comboPublisher.FormattingEnabled = true;
            comboPublisher.Location = new Point(411, 99);
            comboPublisher.Name = "comboPublisher";
            comboPublisher.Size = new Size(121, 23);
            comboPublisher.TabIndex = 7;
            // 
            // comboAuthor
            // 
            comboAuthor.FormattingEnabled = true;
            comboAuthor.Location = new Point(411, 62);
            comboAuthor.Name = "comboAuthor";
            comboAuthor.Size = new Size(121, 23);
            comboAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(99, 99);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(99, 62);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(99, 29);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 1;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(16, 139);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(75, 15);
            labelCount.TabIndex = 6;
            labelCount.Text = "Stock Count:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(330, 139);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(74, 15);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Stock Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "ISBN:";
            // 
            // labeCategory
            // 
            labeCategory.AutoSize = true;
            labeCategory.Location = new Point(330, 32);
            labeCategory.Name = "labeCategory";
            labeCategory.Size = new Size(58, 15);
            labeCategory.TabIndex = 5;
            labeCategory.Text = "Category:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(330, 65);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(47, 15);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Author:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(330, 102);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(59, 15);
            labelPublisher.TabIndex = 4;
            labelPublisher.Text = "Publisher:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(16, 102);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(36, 15);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price:";
            // 
            // tabAuthors
            // 
            tabAuthors.Location = new Point(4, 24);
            tabAuthors.Name = "tabAuthors";
            tabAuthors.Padding = new Padding(3);
            tabAuthors.Size = new Size(768, 434);
            tabAuthors.TabIndex = 1;
            tabAuthors.Text = "Authors";
            tabAuthors.UseVisualStyleBackColor = true;
            // 
            // tabCategory
            // 
            tabCategory.Location = new Point(4, 24);
            tabCategory.Name = "tabCategory";
            tabCategory.Size = new Size(768, 434);
            tabCategory.TabIndex = 2;
            tabCategory.Text = "Categories";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // tabPublishers
            // 
            tabPublishers.Location = new Point(4, 24);
            tabPublishers.Name = "tabPublishers";
            tabPublishers.Size = new Size(768, 434);
            tabPublishers.TabIndex = 3;
            tabPublishers.Text = "Publishers";
            tabPublishers.UseVisualStyleBackColor = true;
            // 
            // tabStocks
            // 
            tabStocks.Location = new Point(4, 24);
            tabStocks.Name = "tabStocks";
            tabStocks.Size = new Size(768, 434);
            tabStocks.TabIndex = 4;
            tabStocks.Text = "Stocks";
            tabStocks.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            tabReports.Location = new Point(4, 24);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(768, 434);
            tabReports.TabIndex = 5;
            tabReports.Text = "Reports";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Stock Management System";
            tabControl.ResumeLayout(false);
            tabBooks.ResumeLayout(false);
            groupAddBook.ResumeLayout(false);
            groupAddBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabBooks;
        private TabPage tabAuthors;
        private TabPage tabCategory;
        private TabPage tabPublishers;
        private TabPage tabStocks;
        private TabPage tabReports;
        private Label labelStatus;
        private Label labelCount;
        private Label labeCategory;
        private Label labelPublisher;
        private Label labelPrice;
        private Label labelAuthor;
        private Label label2;
        private Label label1;
        private GroupBox groupAddBook;
        private ComboBox comboStatus;
        private TextBox txtCount;
        private ComboBox comboCategory;
        private ComboBox comboPublisher;
        private ComboBox comboAuthor;
        private TextBox txtPrice;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private ListBox listBook;
        private Button buttonClear;
        private Button buttonAdd;
    }
}