using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class CategoriesDB
    {
        private const string Dir = @"C:\Users\Public\Documents\";
        private const string Path = Dir + "Categories.csv";
        public static List<CategoriesOld> GetCategories()
        {
            List<CategoriesOld> categories = new List<CategoriesOld>();

            EnsureDirectoryExists();
            if (!File.Exists(Path))
            {
                return categories;
            }

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                CategoriesOld category = new CategoriesOld();
                category.CategoryId = int.Parse(columns[0]);
                category.CategoryName = columns[1];
                categories.Add(category);
            }
            textIn.Close();
            return categories;
        }

        public static void SaveCategories(List<CategoriesOld> categories)
        {
            EnsureDirectoryExists();

            using StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (CategoriesOld category in categories)
            {
                textOut.WriteLine($"{category.CategoryId},{category.CategoryName}");
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

        public static int CountBooksInCategory(string category, List<BookOld> books)
        {
            return books.Count(book => book.Category == category);
        }
    }

}

