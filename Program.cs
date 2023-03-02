using EntitiFramework.Data;
using EntitiFramework.Models;

using EntitiFrameworkContext context = new EntitiFrameworkContext();

/* FLUENT API */
var productss = context.Products
                        .Where(p => p.Price > 10.00M)
                        .OrderBy(p => p.Name);

foreach (Products p in productss)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Id}"); 
    Console.WriteLine($"Price: {p.Id}");
    Console.WriteLine(new string('-',20));
}