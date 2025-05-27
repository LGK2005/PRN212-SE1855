using OOPDemo2;

FullTImeEmployee obama = new()
{
    Id = 1,
    IdCard = "123",
    Name = "Barac Obama",
    BirthDate = new DateTime(1961, 8, 4)
};

Console.WriteLine("--- INFORMATION ---");
Console.WriteLine($"Id = {obama.Id}");
Console.WriteLine($"IdCard = {obama.IdCard}");
Console.WriteLine($"Name = {obama.Name}");
Console.WriteLine($"BirthDate = {obama.BirthDate.ToString("dd/MM/yyyy")}");

Console.WriteLine($"Salary = {obama.TinhLuong()}");

Console.WriteLine("======================");

PartimeEmployee Trump = new()
{ 
    Id=2,
    IdCard = "456",
    Name = "Donal Trump",
    WorkingHours = 72,
    BirthDate = new DateTime(1964, 4, 2)
};

Console.WriteLine("--- INFORMATION ---");
Console.WriteLine($"Id = {Trump.Id}");
Console.WriteLine($"IdCard = {Trump.IdCard}");
Console.WriteLine($"Name = {Trump.Name}");
Console.WriteLine($"BirthDate = {Trump.BirthDate.ToString("dd/MM/yyyy")}");

Console.WriteLine($"Salary = {Trump.TinhLuong()}");

Console.WriteLine("======================");

Console.WriteLine("\n--- ToString ---");
Console.WriteLine(obama);
Console.WriteLine(Trump);