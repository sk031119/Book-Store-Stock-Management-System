using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Stock_Management_System.Controller
{
    public static class PublisherDB
    {
        private const string Dir = @"C:\Users\Public\Documents";
        private const string Path = Dir + @"\Publishers.csv";

        public static List<Publisher> GetPublishers()
        {
            List<Publisher> publishers = new List<Publisher>();

            EnsureDirectoryExists();
            if (!File.Exists(Path))
            {
                return publishers;
            }

            using (StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read)))
            {
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(',');

                    Publisher publisher = new Publisher();
                    if (columns.Length > 0) publisher.Name = columns[0];
                    if (columns.Length > 1) publisher.Address = columns[1];
                    if (columns.Length > 2) publisher.Phone = columns[2];
                    if (columns.Length > 3) publisher.ContactPerson = columns[3];

                    publishers.Add(publisher);
                }
            }

            return publishers;
        }

        public static void SavePublishers(List<Publisher> publishers)
        {
            EnsureDirectoryExists();

            using (StreamWriter textOut = new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (Publisher publisher in publishers)
                {
                    textOut.WriteLine($"{publisher.Name},{publisher.Address},{publisher.Phone},{publisher.ContactPerson}");
                }
            }
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
