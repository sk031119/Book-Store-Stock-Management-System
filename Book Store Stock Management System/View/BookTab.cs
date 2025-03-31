using System;
using Book_Store_Stock_Management_System.Controller;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class BookTab : UserControl
    {
        List<Book> bookList = new List<Book>();

        // To show values in list, not ID
        private List<Author> authors;
        private List<Category> categories;
        private List<Publisher> publishers;


        public BookTab()
        {
            InitializeComponent();

            // Adding ImageList
            ImageList statusIcons = new ImageList();
            statusIcons.ImageSize = new Size(16, 16);

            statusIcons.Images.Add("low-stock", Image.FromFile("Images/error.png"));
            statusIcons.Images.Add("out-of-stock", Image.FromFile("Images/warning.png"));

            listVwBooks.SmallImageList = statusIcons;

            // combo values
            using (var context = new CsdbContext())
            {
                authors = context.Authors.ToList();
                categories = context.Categories.ToList();
                publishers = context.Publishers.ToList();
            }

            // Get data
            bookList = BookDB.GetBooks();
            populateList();
        }

        public void populateList()
        {
            listVwBooks.Items.Clear();

            foreach (var book in bookList)
            {
                var item = new ListViewItem(book.Isbn.ToString());
                item.SubItems.Add(book.Title);
                item.SubItems.Add(authors.FirstOrDefault(a => a.AuthorId == book.AuthorId)?.FullName ?? "Unknown");
                item.SubItems.Add(categories.FirstOrDefault(c => c.CategoryId == book.CategoryId)?.CategoryName ?? "Unknown");
                item.SubItems.Add(publishers.FirstOrDefault(p => p.PublisherId == book.PublisherId)?.Name ?? "Unknown");
                item.SubItems.Add(book.RetailPrice.ToString("C"));
                item.SubItems.Add(book.StockCount.ToString());
                item.SubItems.Add(book.StockStatus);

                item.ImageKey = book.StockStatus.ToLower();

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
                    BookDB.AddBook(newBook);
                    bookList = BookDB.GetBooks();
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

            string isbnText = listVwBooks.SelectedItems[0].SubItems[0].Text;
            long isbn = long.Parse(isbnText);
            Book selectedBook = bookList.FirstOrDefault(b => b.Isbn == isbn);

            if (selectedBook == null)
            {
                MessageBox.Show("Book not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (BookForm bookForm = new BookForm(selectedBook))
            {
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    Book updatedBook = bookForm.bookDetail;
                    BookDB.UpdateBook(updatedBook);
                    bookList = BookDB.GetBooks();
                    populateList();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string title = txtSearch.Text.Trim();
            bookList = BookDB.SearchBooks(title);
            populateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listVwBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose book to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string isbnText = listVwBooks.SelectedItems[0].SubItems[0].Text;
            long isbn = long.Parse(isbnText);
            Book selectedBook = bookList.FirstOrDefault(b => b.Isbn == isbn);

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
                BookDB.DeleteBook(isbn);
                bookList = BookDB.GetBooks();
                populateList();
            }
        }

        private void BookTab_Load(object sender, EventArgs e)
        {

        }

    }
}
