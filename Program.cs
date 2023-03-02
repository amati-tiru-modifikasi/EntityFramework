using EntitiFramework.Data;
using EntitiFramework.Models;

using EntitiFrameworkContext context = new EntitiFrameworkContext();

var veggiSpecial = context.Products
                          .Where(p => p.Name == "Veggie Special Pizza")
                          .FirstOrDefault();

// if null
if(veggiSpecial is Products) {
    veggiSpecial.Price = 10.99M;
}

// persist to db
context.SaveChanges();

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