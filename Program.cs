using EntitiFramework.Data;
using EntitiFramework.Models;

using EntitiFrameworkContext context = new EntitiFrameworkContext();

/* LINK SYNTAK API ~ SQL STYLE */
var productss = from products in context.Products
                where products.Price > 10.00M
                orderby products.Name
                select products;

foreach (Products p in productss)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Name}"); 
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-',20));
}