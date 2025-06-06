using LucySaleManagement;

string connectionString = "Server=DESKTOP-K9GK3MF\\SQLEXPRESS;Database=Lucy_SalesData;User Id=sa;Password=12345;TrustServerCertificate=True";

Lucy_SalesDataDataContext context = new(connectionString);

//Take Customer detail
int id = 1;
Customer customer = context.Customers.FirstOrDefault(c => c.CustomerID == id);

if(customer is not null)
{
    Console.WriteLine(customer.CustomerID + "\t" + customer.ContactName);
}

//Case 2: Take a List of Order from Founded Customer
if(customer is not null)
{
    Console.WriteLine("-- List of Order from Customer --");
    //var list = context.Orders.Where(o => o.CustomerID == id).ToList();

    foreach(Order o in customer.Orders)
    {
        Console.WriteLine(o.OrderID + "\t" + o.OrderDate.ToString("dd/mm/yyyy"));
    }
}

//Case 3: Add Total column to Order table
if (customer is not null)
{
    Console.WriteLine("-- List of Order from Customer --");
    //var list = context.Orders.Where(o => o.CustomerID == id).ToList();
    //decimal sum = context.Order_Details.Sum(o => o.UnitPrice * o.Quantity);
    int sum = ;

    foreach (Order o in customer.Orders)
    {
        Console.WriteLine(o.OrderID + "\t" + o.OrderDate.ToString("dd/mm/yyyy") + "\t" + sum);
    }
}