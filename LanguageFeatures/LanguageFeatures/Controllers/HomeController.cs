using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //creating controller and view
        /*
        public IActionResult Index()
        {
            return View(new string[] { "C#", "Language", "Features" });
        }
        */

        //null conditional operator
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

        //chaining null conditional operator
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

        //combining conditional and coalescing operators
        /*
        public IActionResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {

                string name = p?.Name ?? "<No Name>"; // allow products with null names
                decimal? price = p?.Price ?? 0;
                string related = p?.Related?.Name ?? "<None>";

                //string interpolation
                results.Add($"Name: {name}, Price: {price}, Related: {related}");
            }

            return View(results);
        }
        */

        //object and collection initializers
        /*
        public ViewResult Index()
        {
            string[] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            return View("Index", names);
        }
        */

        /*
        public ViewResult Index()
        {
            return View("Index", new string[] { "Bob", "Joe", "Alice" });
        }
        */

        /*
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

            //index initializer

            Dictionary<string, Product> products = new Dictionary<string, Product>()
            {
                {"Kayak", new Product(){Name = "Kayak", Price = 275M}},
                {"Lifejacket", new Product(){Name = "Lifejacket", Price = 48.95m}}
            };

            Dictionary<string, Product> products = new Dictionary<string, Product>()
            {
                ["Kayak"] = new Product{Name = "Kayak", Price = 275M}},
                ["Lifejacket"] = new Product{Name = "Lifejacket", Price = 48.95m}}
            };
            
        }
        */


        //pattern matching
        /*
        public ViewResult Index()
        {
            object[] data = new object[]
            {
                275M, 29.95M, "apple", "orange", 100, 10
            };

            decimal total = 0;
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] is decimal d)
                {
                    total += d;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
        */

        //pattern matching switch statements
        /*
        public ViewResult Index()
        {
            object[] data = new object[]
            {
                275M, 29.95M, "apple", "orange", 100, 10
            };

            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
        */

        //applying extension methods
        /*
        public IActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart()
            {
                Products = Product.GetProducts()
            };
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        }
        */

        //applying extension methods to interface
        /*
        public IActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart()
            {
                Products = Product.GetProducts()
            };

            decimal cartTotal = cart.TotalPrices();

            Product[] prodArr =
            {
                new Product(){Name="Kayak", Price = 275M},
                new Product(){Name="Lifejacket", Price = 49.95M}
            };

            decimal arrayTotal = prodArr.TotalPrices();

            return View("Index", new string[] { 
                $"Total: {cartTotal:C2}",
                $"Array Total: {arrayTotal:C2}"
            });
        }
        */

        //creating filtering extension methods
        /*
        public IActionResult Index()
        {
            Product[] prodArr =
            {
                new Product(){Name="Kayak",Price=275M},
                new Product(){Name="Lifejacket",Price=48.95M},
                new Product(){Name="Soccer Ball",Price=19.50M},
                new Product(){Name="Corner Flag",Price=34.95M}
            };

            decimal arrayTotal = prodArr.FilterByPrice(20).TotalPrices();

            return View("Index", new string[] {
                $"Array Total: {arrayTotal:C2}"
            });
        }
        */

        //Lambda expressions
        /*
        public IActionResult Index()
        {
            Product[] prodArr =
            {
                new Product(){Name="Kayak",Price=275M},
                new Product(){Name="Lifejacket",Price=48.95M},
                new Product(){Name="Soccer Ball",Price=19.50M},
                new Product(){Name="Corner Flag",Price=34.95M}
            };

            decimal arrayTotal = prodArr.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = prodArr.FilterByName('S').TotalPrices();

            return View("Index", new string[] {
                $"Array Total: {arrayTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"
            });
        }
        */

        //Function to Filter objects
        /*
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }

        bool FilterByName(Product p)
        {
            return p?.Name?[0] == 'S';
        }

        public IActionResult Index()
        {
            Product[] prodArr =
            {
                new Product(){Name="Kayak",Price=275M},
                new Product(){Name="Lifejacket",Price=48.95M},
                new Product(){Name="Soccer Ball",Price=19.50M},
                new Product(){Name="Corner Flag",Price=34.95M}
            };

            decimal arrayTotal = prodArr.Filter(FilterByPrice).TotalPrices();
            decimal nameFilterTotal = prodArr.Filter(FilterByName).TotalPrices();

            return View("Index", new string[] {
                $"Array Total: {arrayTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"
            });
        }
        */

        //Filter with Lambda expression
        /*
        public IActionResult Index()
        {
            Product[] prodArr =
            {
                new Product(){Name="Kayak",Price=275M},
                new Product(){Name="Lifejacket",Price=48.95M},
                new Product(){Name="Soccer Ball",Price=19.50M},
                new Product(){Name="Corner Flag",Price=34.95M}
            };

            decimal arrayTotal = prodArr
                .Filter(p => (p?.Price ?? 0) >= 20)
                .TotalPrices();

            decimal nameFilterTotal = prodArr
                .Filter(p => p?.Name?[0] == 'S')
                .TotalPrices();

            return View("Index", new string[] {
                $"Array Total: {arrayTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"
            });
        }
        */

        //Lambda expression with methods and properties

        /*
        public IActionResult Index()
        {
            return View(Product.GetProducts().Select(p => p?.Name));
        }
        */

        /*
        public ViewResult Index() =>
            View(Product.GetProducts().Select(p => p?.Name));
        */

        /*
        public IActionResult Index()
        {
            IEnumerable<Product> products = Product.GetProducts();
            return View(products.Select(p => p?.Name));
        }
        */

        /*
        public IActionResult Index()
        {
            return View(Product.GetProducts().Where(p=>p?.Category == "Water Craft").Select(p=>p?.Name));
        }
        */

        //Type inference
        /*
        public ViewResult Index()
        {
            var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
            return View(names);
        }
        */

        //Anonymous Types
        /*
        public ViewResult Index()
        {
            var products = new[]
            {
                new {Name = "Kayak", Price = 275M},
                new {Name = "Lifejacket", Price = 48.95M},
                new {Name = "Soccer Ball", Price = 19.50M},
                new {Name = "Corner flag", Price = 34.95M}
            };

            return View(products.Select(p => p.Name));
        }
        */

        //get type
        /*
        public ViewResult Index()
        {
            var products = new[]
            {
                new {Name = "Kayak", Price = 275M},
                new {Name = "Lifejacket", Price = 48.95M},
                new {Name = "Soccer Ball", Price = 19.50M},
                new {Name = "Corner flag", Price = 34.95M}
            };

            return View(products.Select(p => p.GetType().Name));
        }
        */

        //Async methods
        /*
        public async Task<ViewResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });
        }
        */

        //Getting names
        /*
        public ViewResult Index()
        {
            var products = new[]
            {
                new{ Name = "Kayak", Price = 275M},
                new{ Name = "Lifejacket", Price = 48.95M},
                new{ Name = "Soccer Ball", Price = 19.50M},
                new{ Name = "Corner flag", Price = 34.95M}
            };

            return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
        }
        */

        public ViewResult Index()
        {
            var products = new[]
            {
                new{ Name = "Kayak", Price = 275M},
                new{ Name = "Lifejacket", Price = 48.95M},
                new{ Name = "Soccer Ball", Price = 19.50M},
                new{ Name = "Corner flag", Price = 34.95M}
            };

            return View(products.Select(p => 
               $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}
