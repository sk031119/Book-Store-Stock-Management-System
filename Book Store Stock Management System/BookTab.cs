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
    public partial class BookTab : UserControl
    {
        List<Book> bookList = new List<Book>{
            new Book { ISBN = "987654321",  Title = "Harry Potter",Price = 39.99m, Count = 5, Publisher = "HarperCollins", Author = "J. K. Rowling", Category = "Fiction", Status = "Low-stock" },
            new Book { ISBN = "123456789",  Title = "War and Peace",Price = 29.99m, Count = 10, Publisher = "Macmillan", Author = "Alexandre Dumas", Category = "Fiction", Status = "In-stock" }
        };

        public BookTab()
        {
            InitializeComponent();
            // Populate list
            populateList();
        }

        public void populateList()
        {
            listVwBooks.Items.Clear();

            foreach (var book in this.bookList)
            {
                ListViewItem item = new ListViewItem(book.ISBN);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Category);
                item.SubItems.Add(book.Publisher);
                item.SubItems.Add(book.Price.ToString("C"));
                item.SubItems.Add(book.Count.ToString());
                item.SubItems.Add(book.Status);

                listVwBooks.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (BookForm bookForm = new BookForm())
            {
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    Book newBook = bookForm.bookDetail;
                    bookList.Add(newBook);
                    populateList();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listVwBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose book to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listVwBooks.SelectedItems[0];
            string isbn = selectedItem.SubItems[0].Text;
            Book selectedBook = bookList.FirstOrDefault(b => b.ISBN == isbn);

            if (selectedBook == null)
            {
                MessageBox.Show("Book not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calling BookForm as update 
            using (BookForm bookForm = new BookForm(selectedBook))
            {
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    selectedBook.Title = bookForm.bookDetail.Title;
                    selectedBook.ISBN = bookForm.bookDetail.ISBN;
                    selectedBook.Price = bookForm.bookDetail.Price;
                    selectedBook.Count = bookForm.bookDetail.Count;
                    selectedBook.Publisher = bookForm.bookDetail.Publisher;
                    selectedBook.Author = bookForm.bookDetail.Author;
                    selectedBook.Category = bookForm.bookDetail.Category;
                    selectedBook.Status = bookForm.bookDetail.Status;
                    populateList();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string title = txtSearch.Text.Trim();
            List<Book> filteredBook = new List<Book>();

            foreach (Book book in bookList)
            {
                if (book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    filteredBook.Add(book);
                }
            }
            filterList(filteredBook);
        }

        public void filterList(List<Book> books)
        {
            listVwBooks.Items.Clear();

            foreach (var book in books)
            {
                ListViewItem item = new ListViewItem(book.ISBN);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Category);
                item.SubItems.Add(book.Publisher);
                item.SubItems.Add(book.Price.ToString("C"));
                item.SubItems.Add(book.Count.ToString());
                item.SubItems.Add(book.Status);

                listVwBooks.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listVwBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose book to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listVwBooks.SelectedItems[0];
            string isbn = selectedItem.SubItems[0].Text;
            Book selectedBook = bookList.FirstOrDefault(b => b.ISBN == isbn);

            if (selectedBook == null)
            {
                MessageBox.Show("Book not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete " + selectedBook.Title + " ?",
                                               "Confirm",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                bookList.Remove(selectedBook);
                populateList();
            }
        }

        private void BookTab_Load(object sender, EventArgs e)
        {

        }
    }
}
