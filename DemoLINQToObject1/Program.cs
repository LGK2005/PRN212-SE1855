int[] arr = [2, 34, 31, 32, 65, 3, 14, 54];

//Case 1: Sort even number in list
//using extention method - method syntax

var evenList = arr.Where(x => x % 2 == 0);
Console.WriteLine("Danh sách số chẵn trong mảng:");
foreach (var item in evenList)
{
    Console.Write(item + " ");
}

//using Query syntax
var evenListQuery = from x in arr
                    where x % 2 == 0
                    select x;
Console.WriteLine("\nDanh sách số chẵn trong mảng (Query syntax):");
foreach (var item in evenListQuery)
{
    Console.Write(item + " ");
}