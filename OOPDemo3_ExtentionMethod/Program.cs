using OOPDemo3_ExtentionMethod;

int n1 = 5;
Console.WriteLine("Tong tu 1 toi 5 = {0}", n1.TongTu1N());
int n2 = 10;
Console.WriteLine("Tong tu 1 toi 100 = " + n2.TongTu1N());
Console.WriteLine("Tong tu 1 toi 100 = " + 100.TongTu1N());

Console.WriteLine("10 + 20 = " + 10.Cong(20));

Console.WriteLine("========================");

int[] arr = new int[10];
arr.TaoMang();
Console.WriteLine("Before Sort:");
arr.XuatMang();
Console.WriteLine("After Sort:");
arr.SapCepTangDan();
arr.XuatMang();