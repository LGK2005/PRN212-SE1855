// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phuong Trinh Bac 1");
Console.WriteLine("He so a:");
double a = Double.Parse(Console.ReadLine());

Console.WriteLine("He so b:");
double b = Double.Parse(Console.ReadLine());

if(a == 0 && b == 0)
{
    Console.WriteLine("Phuong trinh vo so nghiem");
}
else if(a == 0 && b != 0)
{
    Console.WriteLine("Vo nghiem");
}
else
{
    Console.WriteLine($"X = {-b/a}");
}

Console.ReadLine();
