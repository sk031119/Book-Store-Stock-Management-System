using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Stock_Management_System
{
    public static class PublishersDB
    {
        private const string Dir = @"C:\Users\galaa\Downloads\Ari\C#\Files\";
        private const string Path = Dir + "Publishers.csv";
        public static List<Publisher> GetPublishers()
        {
            List<Publisher> publishers = new List<Publisher>();
            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                Publisher publisher = new Publisher();
                publisher.Name = columns[0];
                publishers.Add(publisher);
            }
            textIn.Close();
            return publishers;
        }

        public static void SavePublishers(List<Publisher> publishers)
        {
            StreamWriter textOut = new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write));
            foreach (Publisher publisher in publishers)
            {
                textOut.Write(publisher.Name + ",");
            }
            textOut.Close();
        }
    }
}
