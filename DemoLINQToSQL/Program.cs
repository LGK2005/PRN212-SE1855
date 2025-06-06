using DemoLINQToSQL;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

string connectionString = "Server=DESKTOP-K9GK3MF\\SQLEXPRESS;Database=MyStore;User Id=sa;Password=12345;TrustServerCertificate=True";

MyStoreDataContext context = new MyStoreDataContext(connectionString);

//Case 1: access category
var db = context.Categories.ToList();

Console.WriteLine("Category List");
db.ForEach(x => Console.WriteLine(x.CategoryID + "\t" + x.CategoryName));

//Case 2: Use query syntax to filter product

var dsp = from p in context.Products select p;

Console.WriteLine("-- Product List --");
foreach (var p in dsp)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}

//Case 3: find category by ID
int dmd = 3;
Category category = context.Categories.FirstOrDefault(x => x.CategoryID == dmd);
if(category is null)
{
    Console.WriteLine("Not found category have ID = " + dmd);
}
else
{
    Console.WriteLine("Found category have ID = " + dmd);
    Console.WriteLine(category.CategoryID + "\t" + category.CategoryName);
}

//Case 4: Filter top 3 Product have highest price
var list = from p in context.Products orderby p descending select p;
var list2 = context.Products.OrderByDescending(x => x.UnitPrice).Take(3);
Console.WriteLine("-- Top 3 Product --");
foreach(var p in list2)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}

//Case 5: Add new category

//Category c1 = new()
//{ 
//    CategoryName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
//};

//context.Categories.InsertOnSubmit(c1);
//context.SubmitChanges();


//Case 6: Change Category name
//Step 1: Find Category
//Step 2: If exist then change name

int id = 9;
Category c = context.Categories.FirstOrDefault(x => x.CategoryID == id);

if(c is null)
{
    Console.WriteLine("Category not found");
}
else
{
    Console.WriteLine("Enter new name for Category: ");
    string name = "CocaCola";

    context.SubmitChanges();
}

//Case 7: Delte Category
Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID == 11);
if(c2 is not null)
{
    context.Categories.DeleteOnSubmit(c2);
    context.SubmitChanges();
}

//Case 8: Delete all Category that have no Product
var emptyCategory = context.Categories.Where(c => c.Products.Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(emptyCategory);
context.SubmitChanges();

//Case 9: Add multiple Category at the same time
List<Category> categories = new List<Category>();
categories.Add(new Category() { CategoryName = "TV" });
categories.Add(new Category() { CategoryName = "PC" });
categories.Add(new Category() { CategoryName = "Phone" });
context.Categories.InsertAllOnSubmit(categories);
context.SubmitChanges();