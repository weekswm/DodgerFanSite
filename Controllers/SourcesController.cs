using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DodgersFanSite.Models;

namespace DodgersFanSite.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Sources()
        {
            return View();
        }

        public ViewResult Book()
        {
            List<Book> books = BookRepository.Books;
            books.Sort((b1, b2) => string.Compare(b1.Title, b2.Title, StringComparison.Ordinal));
            ViewBag.TotalBooks = books.Count();
            return View(books);
        }

        public ViewResult Links()
        {
            List<Link> links = LinkRepository.Links;
            links.Sort((l1, l2) => string.Compare(l1.Desc, l2.Desc, StringComparison.Ordinal));
            ViewBag.TotalLinks = links.Count();
            return View(links);
        }
    }
}