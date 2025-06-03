using OOP5_Dinctionary;

Category c1 = new Category 
{ 
    Id = 1, 
    Name = "Nuoc Ngot" 
};

Product p1 = new Product
{
    Id = 1,
    Name = "Coca",
    Quantity = 10,
    Price = 15
};

c1.AddProduct(p1);

Product p2 = new Product
{
    Id = 2,
    Name = "Pepsi",
    Quantity = 30,
    Price = 15
};

c1.AddProduct(p2);

Product p3 = new Product
{
    Id = 3,
    Name = "String",
    Quantity = 7,
    Price = 20
};

c1.AddProduct(p3);

Product p4 = new Product
{
    Id = 4,
    Name = "RedBull",
    Quantity = 5,
    Price = 18
};

Product p5 = new Product
{
    Id = 5,
    Name = "Sprite",
    Quantity = 8,
    Price = 20
};

c1.AddProduct(p4);
c1.AddProduct(p5);

Dictionary<int, Product> filter = c1.PriceSort(10, 15);

foreach (KeyValuePair<int, Product> p in filter)
{
    Console.WriteLine(p);
}

//c1.DisplayProducts();

Dictionary<int, Product> products = c1.AcsendingSort();
Console.WriteLine("\n\nProducts sorted by price in ascending order:");
foreach (KeyValuePair<int, Product> p in products)
{
    Console.WriteLine(p);
}

Dictionary<int, Product> sortedProducts = c1.Sort();
Console.WriteLine("\n\nProducts sorted by price ascending, then by quantity descending:");
foreach (KeyValuePair<int, Product> p in sortedProducts)
{
    Console.WriteLine(p);
}

p1.Name = "7UP";
p1.Quantity = 30;
p1.Price = 28;
c1.UpdateProduct(p1);
Console.WriteLine("\n\nProducts after update:");
c1.DisplayProducts();

int id = 3;
bool isDeleted = c1.RemoveProduct(id);
if (isDeleted)
{
    Console.WriteLine($"\n\nProduct with ID {id} has been deleted.");
}
else
{
    Console.WriteLine($"\n\nProduct with ID {id} could not be found.");
}

Category c2 = new Category
{
    Id = 2,
    Name = "Bia"
};

c2.AddProduct(new Product
{
    Id = 6,
    Name = "Tiger",
    Quantity = 10,
    Price = 300
});

c2.AddProduct(new Product
{
    Id = 7,
    Name = "Heineken",
    Quantity = 15,
    Price = 200
});

c2.AddProduct(new Product
{
    Id = 8,
    Name = "Saigon",
    Quantity = 7,
    Price = 400
});

LinkedList<Category> categories = new();

categories.AddLast(c1);
categories.AddLast(c2);

Console.WriteLine("\n\nCategories and their products:");
foreach(Category c in  categories)
{
    Console.WriteLine($"Category ID: {c.Id}, Name: {c.Name}");
    c.DisplayProducts();
}