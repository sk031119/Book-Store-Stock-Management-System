using Book_Store_Stock_Management_System.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class CategoriesDB
    {
        // Get all categories
        public static List<Category> GetCategories()
        {
            using (var context = new CsdbContext())
            {
                return context.Categories
                    .OrderBy(c => c.CategoryName)
                    .ToList();
            }
        }

        // Add new category
        public static void AddCategory(Category newCategory)
        {
            using (var context = new CsdbContext())
            {
                context.Categories.Add(newCategory);
                context.SaveChanges();
            }
        }

        // Update existing category
        public static void UpdateCategory(Category updatedCategory)
        {
            using (var context = new CsdbContext())
            {
                var existing = context.Categories.FirstOrDefault(c => c.CategoryId == updatedCategory.CategoryId);
                if (existing != null)
                {
                    existing.CategoryName = updatedCategory.CategoryName;
                    context.SaveChanges();
                }
            }
        }

        // Delete category
        public static bool DeleteCategory(int categoryId, out string errorMessage)
        {
            errorMessage = string.Empty;

            using (var context = new CsdbContext())
            {
                var category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
                if (category != null)
                {
                    try
                    {
                        context.Categories.Remove(category);
                        context.SaveChanges();
                        return true;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        if (dbEx.InnerException is SqlException sqlEx && sqlEx.Number == 547) // FK constraint
                        {
                            errorMessage = "Cannot delete this category because it has related records!";
                        }
                        else
                        {
                            errorMessage = "Database error: " + dbEx.Message;
                        }
                    }
                    catch (Exception ex)
                    {
                        errorMessage = "Unexpected error: " + ex.Message;
                    }
                }
            }

            return false;
        }


        // Count books by category
        public static int CountBooksInCategory(int categoryId)
        {
            using (var context = new CsdbContext())
            {
                return context.Books.Count(book => book.CategoryId == categoryId);
            }
        }
    }
}
