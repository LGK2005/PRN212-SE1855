using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dinctionary
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Product ID: {Id} \t Name: {Name} \t Quantity: {Quantity} \t Price: {Price:C}";
        }
    }
}
