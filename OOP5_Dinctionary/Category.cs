using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dinctionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        public void AddProduct(Product product)
        {
            if (!Products.ContainsKey(product.Id))
            {
                Products.Add(product.Id, product);
            }
            else
            {
                Console.WriteLine($"Product with ID {product.Id} already exists.");
                return;
            }
        }
        public bool RemoveProduct(int productId)
        {
            if (Products.ContainsKey(productId))
            {
                return Products.Remove(productId);
            }
            else
            {
                Console.WriteLine($"Product with ID {productId} does not exist.");
                return false;
            }
        }
        public Product GetProduct(int productId)
        {
            if (Products.TryGetValue(productId, out var product))
            {
                return product;
            }
            else
            {
                Console.WriteLine($"Product with ID {productId} does not exist.");
                return null;
            }
        }
        public void DisplayProducts()
        {
            if (Products.Count == 0)
            {
                Console.WriteLine("No products available in this category.");
                return;
            }
            Console.WriteLine($"Products in Category {Name}:");
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product product = item.Value;
                Console.WriteLine(product);
            }
        }

        public bool UpdateProduct(Product product)
        {
            if (product is null)
                return false;
            if (Products.ContainsKey(product.Id))
            {
                Products[product.Id] = product;
                return true;
            }
            else
            {
                Console.WriteLine($"Product with ID {product.Id} does not exist.");
                return false;
            }
        }

        public Dictionary<int, Product> PriceSort(double min, double max)
        {
            Dictionary<int, Product> result = new();

            result = Products.Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();

            return result;
        }

        public Dictionary<int, Product> AcsendingSort()
        {
            return Products.OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }

        //Sort Product by Price Acsending, if the same then sort by quantity descending
        public Dictionary<int, Product> Sort()
        {
            return Products.OrderBy(item => item.Value.Price)
                .ThenByDescending(item => item.Value.Quantity)
                .ToDictionary<int, Product>();
        }


    }
}
