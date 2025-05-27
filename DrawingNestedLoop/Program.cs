// See https://aka.ms/new-console-template for more information

void hinh1(int n)
{
    int count = 0;
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == n - 1 || i == j)
            {
                Console.Write("*");
            }
            else if (i + j == n - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}

hinh1(8);
