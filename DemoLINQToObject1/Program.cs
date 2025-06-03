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

//Case 2: Sort and increase each odd number in list by 2

var arr2 = arr.Where(x => x % 2 != 0)
              .Select(x => x + 2);

Console.WriteLine("\nDanh sách số lẻ trong mảng tăng thêm 2:");
foreach (var item in arr2)
{
    Console.Write(item + " ");
}

//Case 3: Ascending Sort
var arr3 = arr.OrderBy(x => x);
var arr4 = from x in arr orderby x select x;

Console.WriteLine("\nDanh sách sắp xếp tăng dần:");
foreach (var item in arr3)
{
    Console.Write(item + " ");
}

//Case 4: Descending Sort
var arr5 = arr.OrderByDescending(x => x);
var arr6 = from x in arr orderby x descending select x;

//Case 5: Count odd number
