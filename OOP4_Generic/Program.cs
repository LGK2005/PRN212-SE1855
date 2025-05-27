using OOPDemo2;

Console.WriteLine("--- LIST ---");

List<Employee> list = new();

FullTImeEmployee e1 = new()
{
    Id = 1,
    IdCard = "123",
    Name = "Barac Obama",
    BirthDate = new DateTime(1961, 8, 4)
};

FullTImeEmployee e2 = new()
{
    Id = 2,
    IdCard = "456",
    Name = "asd ada",
    BirthDate = new DateTime(1861, 2, 12)
};

FullTImeEmployee e3 = new()
{
    Id = 3,
    IdCard = "789",
    Name = "yrt yry",
    BirthDate = new DateTime(1931, 11, 2)
};

FullTImeEmployee e4 = new()
{
    Id = 4,
    IdCard = "890",
    Name = "h gfh",
    BirthDate = new DateTime(1861, 10, 20)
};

PartimeEmployee e5 = new()
{
    Id = 5,
    IdCard = "111",
    Name = "Partime 1",
    BirthDate = new DateTime(1990, 1, 1),
    WorkingHours = 3
};

list.Add(e1);
list.Add(e2);
list.Add(e3);
list.Add(e4);
list.Add(e5);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("--- EMPLOYEE SORT ---");

//Cach 1
List<FullTImeEmployee> fList = list.OfType<FullTImeEmployee>().ToList();

//Cach 2
List<FullTImeEmployee> fList2 = 
    list.Where(e => e is FullTImeEmployee).Cast<FullTImeEmployee>().ToList();

//Cach 3
List<FullTImeEmployee> fList3 = new();

foreach (var item in list)
{
    if (item is FullTImeEmployee fullTimeEmployee)
    {
        fList3.Add(fullTimeEmployee);
    }
}

//UPDATE
list[0].Name = "Osama Binladen";
list[1].BirthDate = new DateTime(1990, 10, 10);

Console.WriteLine("--- LIST AFTER UPDATE ---");
list.ForEach(e => Console.WriteLine(e));

//REMOVE
Console.WriteLine("--- LIST BEFORE DELETE ---");
list.ForEach(e => Console.WriteLine(e));

Console.WriteLine("--- LIST AFTER REMOVE ---");
list.RemoveAt(2); // Remove e3
list.ForEach(e => Console.WriteLine(e));

//Salary Cal

double sum = fList2.Sum(e => e.TinhLuong());
Console.WriteLine($"Total salary of full-time employees: {sum}");

//Sort by Date
for(int i = 0; i < fList2.Count - 1; i++)
{
    for (int j = i + 1; j < fList2.Count; j++)
    {
        if (fList2[i].BirthDate > fList2[j].BirthDate)
        {
            var temp = fList2[i];
            fList2[i] = fList2[j];
            fList2[j] = temp;
        }
    }
}

fList2.ForEach(e => Console.WriteLine(e));