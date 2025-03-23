using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Stock_Management_System
{
    public static class AuthorDB
    {
        private const string Dir = @"C:\Users\galaa\Downloads\Ari\C#\Files\";
        private const string Path = Dir + "Author.csv";

        public static List<Author> GetAuthor()
        {
            List<Author> authors = new List<Author>();

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                Author author = new Author();
                author.FName = columns[0];
                author.LName = columns[1];
                authors.Add(author);

            }

            textIn.Close();
            return authors;
        }
        public static void SaveAuthor(List<Author> authors)
        {
            StreamWriter textOut = new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write));
            foreach (Author author in authors)
            {
                textOut.Write(author.FName + ",");
                textOut.WriteLine(author.LName);
            }
            textOut.Close();
        }
    }
}
