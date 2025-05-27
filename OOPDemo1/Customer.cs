using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo1
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void PrintInfor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Customer ID: {Id}");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Customer Address: {Address}");
            Console.WriteLine($"Customer Phone: {Phone}");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine($"Customer ID: {Id}");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Customer Address: {Address}");
            Console.WriteLine($"Customer Phone: {Phone}");
        }
    }
}
