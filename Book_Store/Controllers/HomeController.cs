using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Book_Store.Models;

namespace Book_Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browsing()
        {
            ViewData["Message"] = "This is the browsing.";

            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "This is the book details.";

            return View();
        }

        public IActionResult Ratings()
        {
            ViewData["Message"] = "This is the book rating.";

            return View();
        }

        public IActionResult Cart()
        {
            ViewData["Message"] = "This is the shopping cart.";

            return View();
        }

        public IActionResult Profile()
        {
            ViewData["Message"] = "This is the profile management.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
