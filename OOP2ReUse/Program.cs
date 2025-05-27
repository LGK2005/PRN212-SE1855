using OOP2ReUse;
using OOPDemo2;

Console.WriteLine("--- Tinh Tuoi ---");

FullTImeEmployee e1 = new()
{ 
    Id = 1,
    IdCard = "123",
    Name = "Teo",
    BirthDate = new DateTime(1990, 1, 1)
};

Console.WriteLine("-- Teo Info --");
Console.WriteLine(e1);
Console.WriteLine($"Tuoi: {e1.TinhTuoi()}");