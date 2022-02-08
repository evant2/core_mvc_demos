using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        /*
        public IActionResult Index()
        {
            Product prod = new Product()
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };

            ViewBag.StockLevel = 2;

            return View(prod);
        }
        */
        public IActionResult Index()
        {
            Product[] prodArr = new Product[]
            {
                new Product(){Name = "Kayak", Price = 275M},
                new Product(){Name = "Lifejacket", Price = 48.95m},
                new Product(){Name = "Soccer Ball", Price = 19.50m},
                new Product(){Name = "Corner Flag", Price = 34.95m}
            };

            ViewBag.StockLevel = 2;

            return View(prodArr);
        }
    }
}
