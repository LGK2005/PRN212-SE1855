// See https://aka.ms/new-console-template for more information

Console.WriteLine("Nhap so a:");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Nhap so b:");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Nhap phep toan [+, -, *, /]:");
string op = Console.ReadLine();

double c;

calculate(a, b, op, out c);
Console.WriteLine(c);

Console.ReadLine();

void calculate(double a, double b, string op, out double c)
{
    c = 0;

    switch(op)
    {
        case "+":
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            c = a + b;
            break;
        case "-":
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            c = a - b;
            break;
        case "*":
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            c = a * b;
            break;
        case "/":
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            c = a / b;
            break;
        default:
            Console.WriteLine("Loi phep toan");
            break;
    }
}