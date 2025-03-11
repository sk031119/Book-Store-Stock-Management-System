using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Stock_Management_System
{
    public partial class MainForm : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        List<Book> bookList = new List<Book>();

        // Arrays for comboboxes
        string[] categories = { "Cooking", "Computer", "Horror", "Fiction", "Romance novel" };
        string[] authors = { "Stephen King", "William Shakespeare", "Leo Tolstoy", "Alexandre Dumas", "Victor Hugo" };
        string[] publishers = { "Penguin Random House", "HarperCollins", "Simon & Schuster", "Macmillan", "Hachette Book Group" };
        string[] status = { "In-stock", "Low-stock", "Out-of-stock" };

        public MainForm()
        {
            InitializeComponent();

            // Populating combos
            comboAuthor.Items.AddRange(authors);
            comboCategory.Items.AddRange(categories);
            comboPublisher.Items.AddRange(publishers);
            comboStatus.Items.AddRange(status);

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validating inputs
                if (validateFields())
                {
                    // Adding to list
                    Book newBook = new Book();
                    newBook.Id = bookList.Count;
                    newBook.Title = txtTitle.Text;
                    newBook.ISBN = txtISBN.Text;
                    newBook.Price = Convert.ToDecimal(txtPrice.Text);
                    newBook.Count = Convert.ToInt16(txtCount.Text);
                    newBook.Status = comboStatus.SelectedItem.ToString();
                    newBook.Author = comboAuthor.SelectedItem.ToString(); ;
                    newBook.Category = comboCategory.SelectedItem.ToString();
                    newBook.Publisher = comboPublisher.SelectedItem.ToString();
                    bookList.Add(newBook);

                    // Adding to listbox
                    listBook.Items.Add(newBook.ToString());

                    // Clear fields
                    clearFields();
                    txtTitle.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private Boolean validateFields()
        {
            // Clear previous error messages
            errorProvider.Clear();

            // Title
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errorProvider.SetError(txtTitle, "Enter the title!");
                return false;
            }

            // ISBN
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                errorProvider.SetError(txtISBN, "Enter the ISBN!");
                return false;
            }

            // Price
            decimal priceVal = 0;
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider.SetError(txtPrice, "Enter the price!");
                return false;
            }
            else if (!Decimal.TryParse(txtPrice.Text, out priceVal) || priceVal <= 0)
            {
                errorProvider.SetError(txtPrice, "Count should be more than 0!");
                return false;
            }

            // Count
            int countVal = 0;
            if (string.IsNullOrEmpty(txtCount.Text))
            {
                errorProvider.SetError(txtCount, "Enter the count!");
                return false;
            }
            else if (!int.TryParse(txtCount.Text, out countVal) || countVal <= 0)
            {
                errorProvider.SetError(txtCount, "Count should be more than 0!");
                return false;
            }

            // Category
            if (comboCategory.SelectedItem == null || comboCategory.SelectedIndex < 0)
            {
                errorProvider.SetError(comboCategory, "Select category!");
                return false;
            }

            // Author
            if (comboAuthor.SelectedItem == null || comboAuthor.SelectedIndex < 0)
            {
                errorProvider.SetError(comboAuthor, "Select author!");
                return false;
            }

            // Publisher
            if (comboPublisher.SelectedItem == null || comboPublisher.SelectedIndex < 0)
            {
                errorProvider.SetError(comboPublisher, "Select publisher!");
                return false;
            }

            // Status
            if (comboStatus.SelectedItem == null || comboStatus.SelectedIndex < 0)
            {
                errorProvider.SetError(comboStatus, "Select status!");
                return false;
            }
            return true;
        }
        private void clearFields()
        {
            txtTitle.Clear();
            txtISBN.Clear();
            txtCount.Clear();
            txtPrice.Clear();

            comboAuthor.SelectedIndex = -1;
            comboCategory.SelectedIndex = -1;
            comboPublisher.SelectedIndex = -1;
            comboStatus.SelectedIndex = -1;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }


    }

    class Book
    {
        public int Id;
        public string Title;
        public string ISBN;
        public decimal Price;
        public int Count;
        public string Publisher;
        public string Author;
        public string Category;
        public string Status;

        public Book() { }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, ISBN: {ISBN}, Price: {Price:C}, Count: {Count}, " +
                   $"Publisher: {Publisher}, Author: {Author}, Category: {Category}, Status: {Status}";
        }

    }
}
