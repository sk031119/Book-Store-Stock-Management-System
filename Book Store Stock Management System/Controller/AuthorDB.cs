using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class AuthorDB
    {
        private const string Dir = @"C:\Users\Public\Documents";
        private const string Path = Dir + "\\Author.csv";

        public static List<Author> GetAuthor()
        {
            List<Author> authors = new List<Author>();

            // Check if the file exists, if not, create an empty file
            if (!File.Exists(Path))
            {
                // Ensure the directory exists
                Directory.CreateDirectory(Dir);
                // Create an empty file
                File.Create(Path).Close();
                return authors; // Return an empty list
            }

            using (StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read)))
            {
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(',');
                    Author author = new Author();
                    author.FName = columns[0];
                    author.LName = columns[1];
                    authors.Add(author);
                }
            }

            return authors;
        }

        public static void SaveAuthor(List<Author> authors)
        {
            // Ensure the directory exists
            Directory.CreateDirectory(Dir);

            using (StreamWriter textOut = new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (Author author in authors)
                {
                    textOut.Write(author.FName + ",");
                    textOut.WriteLine(author.LName);
                }
            }
        }
    }
}
