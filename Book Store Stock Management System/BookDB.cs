using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Book_Store_Stock_Management_System.BookDB;

namespace Book_Store_Stock_Management_System
{
    public static class BookDB
    {
        private const string Dir = @"C:\Users\galaa\Downloads\Ari\C#\Files\";
        private const string Path = Dir + "Books.csv";

        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                Book book = new Book();
                book.ISBN = columns[0];
                book.Title = columns[1];
                books.Add(book);
            }

            textIn.Close();
            return books;
        }

    }
}
