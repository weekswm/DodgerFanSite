using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class Book
    {
        private List<Book> books = new List<Book>();

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }

        public List<Book> Books { get { return books; } }
    }
}
