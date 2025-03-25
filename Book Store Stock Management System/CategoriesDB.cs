using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Stock_Management_System
{
    public static class CategoriesDB
    {
        public static List<Categories> GetCategories()
        {
            List<Categories> categories = new List<Categories>();
            categories.Add(new Categories { CatCode = "001", CatName = "Science" });
            categories.Add(new Categories { CatCode = "002", CatName = "Mathematics" });
            categories.Add(new Categories { CatCode = "003", CatName = "History" });
            categories.Add(new Categories { CatCode = "004", CatName = "Literature" });
            categories.Add(new Categories { CatCode = "005", CatName = "Computer Science" });
            categories.Add(new Categories { CatCode = "006", CatName = "Engineering" });
            categories.Add(new Categories { CatCode = "007", CatName = "Medicine" });
            categories.Add(new Categories { CatCode = "008", CatName = "Business" });
            categories.Add(new Categories { CatCode = "009", CatName = "Economics" });
            categories.Add(new Categories { CatCode = "010", CatName = "Law" });
            return categories;
        }
        public static int CountBooksInCategory(string category, List<Book> books)
        {
            return books.Count(book => book.Category == category);
        }

    }
}
