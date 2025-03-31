using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Store_Stock_Management_System.Controller;

namespace Book_Store_Stock_Management_System
{
    public partial class BookTab : UserControl
    {
        List<Book> bookList = new List<Book>();

        public BookTab()
        {
            InitializeComponent();
            bookList = BookDB.GetBooks();

            // Populate list
            populateList();
        }

        public void populateList()
        {
            listVwBooks.Items.Clear();

            var items = bookList.Select(book => new ListViewItem(book.ISBN)
            {
                SubItems = {
                        book.Title,
                        book.Author,
                        book.Category,
                        book.Publisher,
                        book.Price.ToString("C"),
                        book.Count.ToString(),
                        book.Status
                    }
            }).ToArray();

            listVwBooks.Items.AddRange(items);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (BookForm bookForm = new BookForm())
            {
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    Book newBook = bookForm.bookDetail;
                    bookList.Add(newBook);
                    BookDB.SaveBooks(bookList);
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
                    BookDB.SaveBooks(bookList);
                    populateList();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string title = txtSearch.Text.Trim();
            var filteredBook = bookList.Where(book => book.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
            filterList(filteredBook);
        }

        public void filterList(List<Book> books)
        {
            listVwBooks.Items.Clear();

            var items = books.Select(book => new ListViewItem(book.ISBN)
            {
                SubItems = {
                        book.Title,
                        book.Author,
                        book.Category,
                        book.Publisher,
                        book.Price.ToString("C"),
                        book.Count.ToString(),
                        book.Status
                    }
            }).ToArray();

            listVwBooks.Items.AddRange(items);
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
                BookDB.SaveBooks(bookList);
                populateList();
            }
        }

        private void BookTab_Load(object sender, EventArgs e)
        {

        }
    }
}
