// See https://aka.ms/new-console-template for more information

/*
    input a number >= 0
    if false => input again
    if true => calculate !n
 */
int n = -1;
do
{
    Console.WriteLine("Nhap n (n >= 0): ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out n) == true)
    {
        if (n < 0)
        {
            Console.WriteLine("Nhap so lon hon 0");
        }
        else
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Nhap sai, nhap lai: ");
        n = -1;
    }
}
while (n < 0);

int giaiThua;

TinhGiaiThua(n, out giaiThua);

Console.WriteLine($"Giai thua cua {n} la: {giaiThua}");

void TinhGiaiThua(int n, out int giaithua)
{
    giaithua = 1;

    for(int i = 1; i <= n; i++)
    {
        giaithua *= i;
    }
}
