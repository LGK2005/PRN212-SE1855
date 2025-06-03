using DemoAliasAndClone;

Student s1 = new()
{
    Id = 1,
    Name = "Alice"
};

Student s2 = new()
{
    Id = 2,
    Name = "Bob"
};

//Ram will be allocated for s1 and s2

s1 = s2;
//s1 and s2 will point to the same object in memory now
//but s1 is not equal to s2
//s1 and s2 are aliases for the same object
////If we change the properties of s2, it will also affect s1

s2.Name = "Charlie";
//s1.Name will also be "Charlie" because they point to the same object
Console.WriteLine(s1);

//the memory that allocated for s1 before the assignment will be garbage collected (AGC)

Product p1 = new()
{
    Id = 1,
    Name = "Laptop",
    Quantity = 10,
    Price = 999.99m
};

Product p2 = p1.Clone();

//p2 is a clone of p1, so they are different objects in memory
Console.WriteLine("p1 Data:");
Console.WriteLine(p1);

Console.WriteLine("p2 Data:");
Console.WriteLine(p2);

p1.Name = "Gaming Laptop";
//p2.Name will not be affected by the change in p1
Console.WriteLine("After changing p1.Name:");
Console.WriteLine("p1 Data:");
Console.WriteLine(p1);

Console.WriteLine("p2 Data:");
Console.WriteLine(p2);