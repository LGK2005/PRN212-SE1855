using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo3_ExtentionMethod
{
    public static class MyUtils
    {
        //1. import a function TongTu1N
        //input is int from Microsoft

        public static int TongTu1N(this int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static int Cong(this int a, int b)
        {
            return a + b;
        }

        public static void SapCepTangDan(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void TaoMang(this int[] arr)
        {
            Random ran = new();
            for(int i = 0 ; i < arr.Length ; i++)
            {
                arr[i] = ran.Next(1, 100);
            }
        }

        public static void XuatMang(this int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        //Viet 1 ham tra ve cac so nguyen to tu 1 --> N

    }
}
