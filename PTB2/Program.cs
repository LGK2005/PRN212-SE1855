// See https://aka.ms/new-console-template for more information

using System.Numerics;

void ptb1(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("Phuong trinh vo so nghiem");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else
    {
        Console.WriteLine($"X = {-b / a}");
    }
}

void ptb2(double a, double b, double c)
{
    if (a == 0)
        ptb1(b, c);

    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta == 0)
            Console.WriteLine("Phuong trinh co nghiem kep = {0}", -b / (2 * a));
        else if (delta < 0)
            Console.WriteLine("Phuong trinh vo nghiem");
        else
        {
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Co 2 nghiem phan biet X1 = {0} | X2 = {1}", x1, x2);
        }
    }
}

Console.WriteLine("PTB2: ax^2 + bx + c = 0");

Console.WriteLine("He so a:");
var a = Double.Parse(Console.ReadLine());

Console.WriteLine("He so b:");
var b = Double.Parse(Console.ReadLine());

Console.WriteLine("He so c:");
var c = Double.Parse(Console.ReadLine());

ptb2(a, b, c);