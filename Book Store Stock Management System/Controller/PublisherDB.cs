using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Store_Stock_Management_System.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class PublisherDB
    {
        // Get all publishers from the database
        public static List<Publisher> GetPublishers()
        {
            using (var context = new CsdbContext())
            {
                return context.Publishers
                    .OrderBy(p => p.Name)
                    .ToList();
            }
        }

        // Add a new publisher to the database
        public static void AddPublisher(Publisher newPublisher)
        {
            using (var context = new CsdbContext())
            {
                context.Publishers.Add(newPublisher);
                context.SaveChanges();
            }
        }

        // Update an existing publisher
        public static void UpdatePublisher(Publisher updatedPublisher)
        {
            using (var context = new CsdbContext())
            {
                var existingPublisher = context.Publishers.FirstOrDefault(p => p.PublisherId == updatedPublisher.PublisherId);
                if (existingPublisher != null)
                {
                    existingPublisher.Name = updatedPublisher.Name;
                    existingPublisher.Address = updatedPublisher.Address;
                    existingPublisher.Phone = updatedPublisher.Phone;
                    existingPublisher.ContactPerson = updatedPublisher.ContactPerson;

                    context.SaveChanges();
                }
            }
        }

        // Delete publisher
        public static bool DeletePublisher(int publisherId, out string errorMessage)
        {
            errorMessage = string.Empty;

            using (var context = new CsdbContext())
            {
                var publisher = context.Publishers.FirstOrDefault(p => p.PublisherId == publisherId);
                if (publisher != null)
                {
                    try
                    {
                        context.Publishers.Remove(publisher);
                        context.SaveChanges();
                        return true;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        if (dbEx.InnerException is SqlException sqlEx && sqlEx.Number == 547)
                        {
                            errorMessage = "Cannot delete this publisher because it has related records!";
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

        // Search by name
        public static List<Publisher> SearchPublishers(string name)
        {
            using (var context = new CsdbContext())
            {
                return context.Publishers
                    .Where(p => p.Name.Contains(name))
                    .OrderBy(p => p.Name)
                    .ToList();
            }
        }
    }
}
