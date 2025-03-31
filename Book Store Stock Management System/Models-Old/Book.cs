using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Stock_Management_System
{
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
