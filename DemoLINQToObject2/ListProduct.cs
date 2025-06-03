using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQToObject2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }

        public void GenerateProduct()
        {
            products.Add(new Product { Id = 1, Name = "Apple", Quantity = 10, Price = 0.5 });
            products.Add(new Product { Id = 2, Name = "Banana", Quantity = 20, Price = 0.3 });
            products.Add(new Product { Id = 3, Name = "Cherry", Quantity = 15, Price = 0.2 });
            products.Add(new Product { Id = 4, Name = "Date", Quantity = 5, Price = 1.0 });
            products.Add(new Product { Id = 5, Name = "Adf", Quantity = 32, Price = 3.0 });
            products.Add(new Product { Id = 6, Name = "fdsf", Quantity = 2, Price = 2.0 });
            products.Add(new Product { Id = 7, Name = "Ad65646f", Quantity = 12, Price = 1.2 });
            products.Add(new Product { Id = 8, Name = "jghj", Quantity = 30, Price = 0.7 });
            products.Add(new Product { Id = 9, Name = "iuyiu", Quantity = 22, Price = 1.5 });
            products.Add(new Product { Id = 10, Name = "cxzcz", Quantity = 11, Price = 7.0 });
        }

        public List<Product> FilterProductByPrice(double price1, double price2)
        {
            return products.Where(p => p.Price >= price1 && p.Price <= price2)
                           .ToList();
        }

        public List<Product> FilterProductByPrice2(double price1, double price2)
        {
            var rs = from p in products
                     where p.Price >= price1 && p.Price <= price2
                     select p;

            return rs.ToList();
        }

        public List<Product> SortProductByPriceDescending()
        {
            return products.OrderByDescending(p => p.Price)
                           .ToList();
        }

        public List<Product> SortProductByPriceDescendign2()
        {
            var rs = from p in products
                     orderby p.Price descending
                     select p;

            return rs.ToList();
        }

        public double CalculateTotalPrice()
        {
            return products.Sum(p => p.Price * p.Quantity);
        }
    }
}
