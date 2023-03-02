using EntitiFramework.Data;
using EntitiFramework.Models;

using EntitiFrameworkContext context = new EntitiFrameworkContext();

Products veggieSpecial = new Products() {
    Name = "Veggie Special Pizza",
    Price = 9.99M
};
context.Products.Add(veggieSpecial);

Products deluxeMeat = new Products() {
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};
context.Add(deluxeMeat);

context.SaveChanges();