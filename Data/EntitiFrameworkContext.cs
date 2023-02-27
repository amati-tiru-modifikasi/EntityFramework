using EntitiFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntitiFramework.Data;

public class EntitiFrameworkContext : DbContext
{
    public DbSet<Customer> Customers {get; set;} = null;
    public DbSet<Order> Orders {get; set;} = null;
    public DbSet<Product> Products {get; set;} = null;
    public DbSet<OrderDetail> OrderDetails {get; set;} = null;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer(@"Data Source=HP-PROBOOK;Initial Catalog=latihan;Integrated Security=True;TrustServerCertificate=True;");
    }

}
