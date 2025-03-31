using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class BookDB
    {
        // Get all books from the database
        public static List<Book> GetBooks()
        {
            using (var context = new CsdbContext())
            {
                return context.Books
                    .OrderBy(b => b.Title)
                    .ToList();
            }
        }

        // Add a new book to the database
        public static void AddBook(Book newBook)
        {
            using (var context = new CsdbContext())
            {
                context.Books.Add(newBook);
                context.SaveChanges();
            }
        }

        // Update an existing book
        public static void UpdateBook(Book updatedBook)
        {
            using (var context = new CsdbContext())
            {
                var existingBook = context.Books.FirstOrDefault(b => b.Isbn == updatedBook.Isbn);
                if (existingBook != null)
                {
                    existingBook.Title = updatedBook.Title;
                    existingBook.RetailPrice = updatedBook.RetailPrice;
                    existingBook.StockCount = updatedBook.StockCount;
                    existingBook.StockStatus = updatedBook.StockStatus;
                    existingBook.AuthorId = updatedBook.AuthorId;
                    existingBook.CategoryId = updatedBook.CategoryId;
                    existingBook.PublisherId = updatedBook.PublisherId;

                    context.SaveChanges();
                }
            }
        }

        // Delete book
        public static void DeleteBook(long isbn)
        {
            using (var context = new CsdbContext())
            {
                var book = context.Books.FirstOrDefault(b => b.Isbn == isbn);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
        }

        // Search by title
        public static List<Book> SearchBooks(string title)
        {
            using (var context = new CsdbContext())
            {
                return context.Books
                    .Where(b => b.Title.Contains(title))
                    .OrderBy(b => b.Title)
                    .ToList();
            }
        }
    }
}
