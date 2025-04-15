using System;
using System.Collections.Generic;
using System.Linq;
using Book_Store_Stock_Management_System.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class AuthorDB
    {
        // Get all authors from the database
        public static List<Author> GetAuthors()
        {
            using (var context = new CsdbContext())
            {
                return context.Authors
                    .OrderBy(a => a.LastName)
                    .ThenBy(a => a.FirstName)
                    .ToList();
            }
        }

        // Add a new author to the database
        public static void AddAuthor(Author newAuthor)
        {
            using (var context = new CsdbContext())
            {
                context.Authors.Add(newAuthor);
                context.SaveChanges();
            }
        }

        // Update an existing author
        public static void UpdateAuthor(Author updatedAuthor)
        {
            using (var context = new CsdbContext())
            {
                var existingAuthor = context.Authors.FirstOrDefault(a => a.AuthorId == updatedAuthor.AuthorId);
                if (existingAuthor != null)
                {
                    existingAuthor.FirstName = updatedAuthor.FirstName;
                    existingAuthor.LastName = updatedAuthor.LastName;
                    context.SaveChanges();
                }
            }
        }

        // Delete author
        public static bool DeleteAuthor(int authorId, out string errorMessage)
        {
            errorMessage = string.Empty;

            using (var context = new CsdbContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.AuthorId == authorId);
                if (author != null)
                {
                    try
                    {
                        context.Authors.Remove(author);
                        context.SaveChanges();
                        return true;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        if (dbEx.InnerException is SqlException sqlEx && sqlEx.Number == 547)
                        {
                            errorMessage = "Cannot delete this author because there are still related book records!";
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

        // Search by author name
        public static List<Author> SearchAuthors(string name)
        {
            using (var context = new CsdbContext())
            {
                return context.Authors
                    .Where(a => a.FirstName.Contains(name) || a.LastName.Contains(name))
                    .OrderBy(a => a.LastName)
                    .ThenBy(a => a.FirstName)
                    .ToList();
            }
        }
    }
}
