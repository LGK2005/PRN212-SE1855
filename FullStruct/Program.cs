using System;

namespace FullStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}