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
    public partial class BookForm : Form
    {
        public Book bookDetail;
        Boolean isNew = true;

        private ErrorProvider errorProvider = new ErrorProvider();

        // Arrays for comboboxes
        string[] categories = { "Cooking", "Computer", "Horror", "Fiction", "Romance novel" };
        string[] authors = { "Stephen King", "William Shakespeare", "Leo Tolstoy", "Alexandre Dumas", "Victor Hugo" };
        string[] publishers = { "Penguin Random House", "HarperCollins", "Simon & Schuster", "Macmillan", "Hachette Book Group" };
        string[] status = { "In-stock", "Low-stock", "Out-of-stock" };

        public BookForm()
        {
            InitializeComponent();

            // Populating combos
            populateCombos();
        }

        public BookForm(Book book)
        {
            InitializeComponent();

            this.isNew = false;

            // Populating combos
            populateCombos();
            txtISBN.Enabled = false;

            bookDetail = book;
            txtTitle.Text = book.Title;
            txtISBN.Text = book.ISBN;
            txtPrice.Text = book.Price.ToString();
            txtCount.Text = book.Count.ToString();
            comboPublisher.SelectedItem = book.Publisher;
            comboAuthor.SelectedItem = book.Author;
            comboCategory.SelectedItem = book.Category;
            comboStatus.SelectedItem = book.Status;
        }

        private void populateCombos()
        {
            comboAuthor.Items.AddRange(authors);
            comboCategory.Items.AddRange(categories);
            comboPublisher.Items.AddRange(publishers);
            comboStatus.Items.AddRange(status);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validating inputs
                if (validateFields())
                {
                    // Adding to list
                    this.bookDetail = new Book
                    {
                        Title = txtTitle.Text,
                        ISBN = txtISBN.Text,
                        Price = Convert.ToDecimal(txtPrice.Text),
                        Count = Convert.ToInt16(txtCount.Text),
                        Status = comboStatus.SelectedItem.ToString(),
                        Author = comboAuthor.SelectedItem.ToString(),
                        Category = comboCategory.SelectedItem.ToString(),
                        Publisher = comboPublisher.SelectedItem.ToString()
                    };
                    MessageBox.Show(isNew ? "Successfully added" : "Successfully updated");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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

        private void BookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
