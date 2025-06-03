using DemoLINQToObject2;

ListProduct listProduct = new ListProduct();
listProduct.GenerateProduct();

//Case 1:Sort Product Price from a to b
//using Method Syntax - Query Syntax

var sortedProducts = listProduct.FilterProductByPrice(1, 5);
foreach (var product in sortedProducts)
{
    Console.WriteLine(product);
}

Console.WriteLine("--------------------------------------------------");

//Case 2: Sort Product Price Descending
//using Method Syntax - Query Syntax

var sortList = listProduct.SortProductByPriceDescending();
foreach (var product in sortList)
{
    Console.WriteLine(product);
}

//Case 3: Calculate Total Price of Products

double total = listProduct.CalculateTotalPrice();
Console.WriteLine($"Total Price of Products: {total}");