using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Book_Store_Stock_Management_System.BookDB;

namespace Book_Store_Stock_Management_System
{
    public static class BookDB
    {
        private const string Dir = @"C:\Users\Public\Documents\";
        private const string Path = Dir + "Books.csv";
        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            EnsureDirectoryExists();
            if (!File.Exists(Path))
            {
                return books;
            }

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                Book book = new Book();
                book.ISBN = columns[0];
                book.Title = columns[1];
                book.Author = columns[2];
                book.Publisher = columns[3];
                book.Price = Decimal.Parse(columns[4]);
                book.Count = int.Parse(columns[5]);
                book.Category = columns[6];
                book.Status = columns[7];
                books.Add(book);
            }

            textIn.Close();
            return books;
        }

        public static void SaveBooks(List<Book> books)
        {
            EnsureDirectoryExists();

            using StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (Book customer in books)
            {
                textOut.WriteLine($"{customer.ISBN},{customer.Title},{customer.Author},{customer.Publisher},{customer.Price},{customer.Count},{customer.Category},{customer.Status}");
            }
            textOut.Close();
        }

        private static void EnsureDirectoryExists()
        {
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
        }
    }
}
