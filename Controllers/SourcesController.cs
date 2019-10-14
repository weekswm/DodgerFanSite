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
            return View();
        }

        public ViewResult Links()
        {
            return View();
        }
    }
}