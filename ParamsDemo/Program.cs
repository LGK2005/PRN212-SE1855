// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;

int[] arr = new int[10];

createArray(arr);
//IncreaseSort(arr);
//SortDoWhile(arr);
SortWhile(arr);

void IncreaseSort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
                Swap(ref arr[i], ref arr[j]);
        }    
    }

    showList(arr);
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void createArray(int[] arr)
{
    Random rd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(1, 100);
    }
}

void SortDoWhile(int[] arr)
{
    int i = 0;
    do
    {
        int j = i + 1;
        do
        {
            if(j >= arr.Length)
            {
                break;
            }

            if (arr[i] > arr[j])
            {
                Swap(ref arr[i], ref arr[j]);
            }

            j++;
        }
        while(j < arr.Length);
        i++;
    }
    while(i < arr.Length);

    showList(arr);
}

void SortWhile(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        int j = i + 1;
        while(j < arr.Length)
        {
            if (arr[i] > arr[j])
            {
                Swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        i++;
    }

    showList(arr);
}

void showList(int[] arr)
{
    Console.WriteLine("Mang sau khi sap xep tang dan: ");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
}