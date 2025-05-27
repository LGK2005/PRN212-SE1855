using OOPDemo1;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc Mam";

c1.PrintInformation();

Employee e1 = new Employee();

e1.Id = 1;
e1.Cccd = "213345";
e1.Name = "John Wick";
e1.Email = "WickThePencil@gmail.com";
e1.Phone = "09213432";

e1.PrintInfor();

Console.WriteLine("------------------");
Console.WriteLine("Id e1: " + e1.Id);
Console.WriteLine("Cccd e1: " + e1.Cccd);

Employee e2 = new Employee()
{
    Id = 2,
    Cccd = "32114324",
    Name = "sada",
    Email = " sada432@gmail.com",
    Phone = "0944234567"
};

Console.WriteLine("=================");
e2.PrintInfor();

Console.WriteLine("=================");
Employee e3 = new Employee(3, "Kotlin", "KKK@gmail.com", "094324543", "2136789");

e3.PrintInfor();

Console.WriteLine(e3);

Console.WriteLine("=================");
Employee e4 = new();
e4.PrintInfor();

Console.WriteLine("=================");
Customer customer = new Customer()
{
    Id = 1,
    Name = "asdsafds",
    Address = "12 dsada 4grfdgd",
    Email = "sada@gmail.com",
    Phone = "0932137"
};

customer.PrintInfor();