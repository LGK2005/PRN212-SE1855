// See https://aka.ms/new-console-template for more information

using System.Text;

string ho = "Lam";
string tenLot = "Thi";
String ten = "Teo";
string fullName = ho + " " + tenLot + " " + ten;
string fullNameV2 = $"{ho} {tenLot} {ten}";
StringBuilder sb = new StringBuilder();

sb.Append(ho).Append(" ").Append(tenLot).Append(" ").Append(ten);

Console.WriteLine(fullName);
Console.WriteLine(fullNameV2);
Console.WriteLine(sb.ToString());