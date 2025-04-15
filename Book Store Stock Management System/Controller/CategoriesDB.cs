using Book_Store_Stock_Management_System.Models;
using Microsoft.Data.SqlClient;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class CategoriesDB
    {

        private static string connectionString = @"Server=tcp:bookstore-cs.database.windows.net,1433;
                                                    Initial Catalog=csdb;
                                                    Persist Security Info=False;
                                                    User ID=cs-admin;
                                                    Password=SQL-server;
                                                    MultipleActiveResultSets=False;
                                                    Encrypt=True;
                                                    TrustServerCertificate=False;
                                                    Connection Timeout=30;";

        // Get all categories
        public static List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            string query = "SELECT CategoryId, CategoryName FROM Categories ORDER BY CategoryName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Category
                    {
                        CategoryId = reader.GetInt32(0),
                        CategoryName = reader.GetString(1)
                    });
                }
                reader.Close();
            }

            return categories;
        }

        // Add new category
        public static void AddCategory(Category newCategory)
        {
            string query = "INSERT INTO Categories (CategoryName) VALUES (@name)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", newCategory.CategoryName);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update existing category
        public static void UpdateCategory(Category updatedCategory)
        {
            string query = "UPDATE Categories SET CategoryName = @name WHERE CategoryId = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", updatedCategory.CategoryName);
                cmd.Parameters.AddWithValue("@id", updatedCategory.CategoryId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete category
        public static bool DeleteCategory(int categoryId, out string errorMessage)
        {
            errorMessage = string.Empty;
            string query = "DELETE FROM Categories WHERE CategoryId = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // foreign key constraint
                    errorMessage = "Cannot delete this category because it has related records!";
                else
                    errorMessage = "SQL Error: " + ex.Message;

                return false;
            }
        }
    }
}
