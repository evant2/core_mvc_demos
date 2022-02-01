using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        /*
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product p in cartParam.Products)
            {
                total += p?.Price ?? 0;
            }

            return total;
        }
        */

        
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product p in products)
            {
                total += p?.Price ?? 0;
            }

            return total;
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> product, decimal minPrice)
        {
            List<Product> prodList = new List<Product>();
            
            foreach(Product p in product)
            {
                if((p?.Price ?? 0) >= minPrice)
                {
                    //prodList.Add(p);
                    yield return p;
                }
            }

            //return prodList;
        }

        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> products, char firstLetter)
        {
            foreach (Product p in products)
            {
                if(p?.Name[0] == firstLetter)
                {
                    yield return p;
                }
            }
        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> products, Func<Product,bool> selector)
        {
            foreach (Product p in products)
            {
                if (selector(p))
                {
                    yield return p;
                }
            }
        }
    }
}
