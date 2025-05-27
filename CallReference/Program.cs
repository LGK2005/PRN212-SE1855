// See https://aka.ms/new-console-template for more information

/*
    Difference between ref and out:
    - ref: The variable must be initialized before being passed to the method.
    - out: The variable does not need to be initialized before being passed to the method. 
            However, it must be assigned a value before the method returns.
 */

/* Call By Refernce -- using ref */

Console.WriteLine("Call By Reference - using ref");
Console.WriteLine("Nhap a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Before Swap ------ a = {a}, b = {b}");

Swap(ref a, ref b);

Console.WriteLine($"After Swap ------ a = {a}, b = {b}");

Console.WriteLine("\nCall By Reference - using out");
int c;
int d;

initNumber(out c, out d);

Console.WriteLine($"c = {c}, d = {d}");

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

/* Call By Reference -- using out */

void initNumber(out int c, out int d)
{
    c = 10;
    d = 20;
}