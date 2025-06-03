using System.Security.Cryptography.X509Certificates;

class Program
{
    public delegate int MyDelegate(int x, int y);
    static int Add(int x, int y)
    {
        return x + y;
    }
    static int Subtract(int x, int y)
    {
        return x - y;
    }

    public delegate int[] MyArrayDelegate(int n);

    static int[] DanhSachSoChan(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2; i <= n; i += 2)
        {
            list.Add(i);
        }

        return list.ToArray();
    }

    static int[] DachSachSoNguyenTo(int n)
    {
        List <int> list = new List<int>();
        for(int i = 2; i < n; i++)
        {
            int count = 0;
            for(int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }

            if (count == 2)
                list.Add(i);
        }

        return list.ToArray();
    }

    static void Main(string[] args)
    {
        MyDelegate myDelegate = new MyDelegate(Add);
        Console.WriteLine("Total: " + myDelegate(5, 10));

        myDelegate = Subtract;
        Console.WriteLine("Total: " + myDelegate(10, 5));

        MyArrayDelegate myArrayDelegate = new MyArrayDelegate(DanhSachSoChan);
        int n = 20;
        int[] result = myArrayDelegate(n);

        Console.WriteLine("Danh sách số chẵn từ 1 đến " + n + ":");
        foreach (int item in result)
        {
            Console.Write(item + " ");
        }

        int[] result2 = DachSachSoNguyenTo(n);
        Console.WriteLine("\nDanh sách số nguyên tố từ 1 đến " + n + ":");
        foreach (int item in result2)
        {
            Console.Write(item + " ");
        }
    }
}