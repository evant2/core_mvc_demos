using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View(new string[] { "C#", "Language", "Features" });
        }
        */

        /*
        public IActionResult Index()
        {
            List<string> results = new List<string>();

            foreach(Product p in Product.GetProducts())
            {
                string name = p?.Name; // allow products with null names
                decimal? price = p?.Price;
                results.Add(string.Format("Name: {0}, Price: {1}", name, price));
            }

            return View(results);
        }
        */

        /*
        public IActionResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {

                string name = p?.Name ?? "<No Name>"; // allow products with null names
                decimal? price = p?.Price ?? 0;
                string related = p?.Related?.Name ?? "<None>";

                results.Add(string.Format("Name: {0}, Price: {1} Related: {2}", name, price, related));
            }

            return View(results);
        }
        */

        public IActionResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {

                string name = p?.Name ?? "<No Name>"; // allow products with null names
                decimal? price = p?.Price ?? 0;
                string related = p?.Related?.Name ?? "<None>";

                results.Add($"Name: {name}, Price: {price}, Related: {related}");
            }

            return View(results);
        }

        private void Test()
        {
            //object initializer
            Product kayak = new Product()
            {
                Name = "kayak",
                Price = 275M,
                Category = "watercraft"
            };

            //collection initializer
            string[] names = new string[]
            {
                "Greg", "Sophie", "Bryden"
            };

            Dictionary<string, Product> products = new Dictionary<string, Product>()
            {
                {"Kayak", new Product(){Name = "Kayak", Price = 275M}},
                {"Lifejacket", new Product(){Name = "Lifejacket", Price = 48.95m}}
            };
            
        }


    }
}
