using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class BookRepository
    {
        private static List<Book> books = new List<Book>();
        public static List<Book> Books { get { return books; } }

        static BookRepository()
        {
            AddTestData();
        }

        public static void AddBook(Book book)
        {
            books.Add(book);
        }

        public static Book GetBookByTitle(string title)
        {
            Book book = books.Find(b => b.Title == title);
            return book;
        }

        static void AddTestData()
        {
            Book book = new Book()
            {
                Title = "True Blue: The Dramatic History of the Los Angeles Dodgers, Told by the Men Who Lived It",
                Author = "Steve Delsohn",
                PubDate = new DateTime(2002, 3, 5)
            };
            books.Add(book);

            book = new Book()
            {
                Title = "The Dodgers Encyclopedia",
                Author = "William F. McNeil",
                PubDate = new DateTime(2012, 7, 1)
            };

            book = new Book()
            {
                Title = "100 Things Dodgers Fans Should Know & Do Before They Die (100 Things...Fans Should Know)",
                Author = "Jon Weisman",
                PubDate = new DateTime(2013, 4, 1)
            };
            books.Add(book);

            book = new Book()
            {
                Title = "The Dodgers: 60 Years in Los Angeles",
                Author = "Michael Schiavone",
                PubDate = new DateTime(2018, 5, 1)
            };
            books.Add(book);

            book = new Book()
            {
                Title = "The 50 Greatest Dodgers Games of All Time",
                Author = "J.P. Hoornstra",
                PubDate = new DateTime(2015, 6, 24)
            };
            books.Add(book);
        }
    }
}
