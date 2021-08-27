using Microsoft.EntityFrameworkCore;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class DataAdapter : DbContext //DbConnect expects OnConfiguring()
  {
    public DbSet<Customer> Customers { get; set; } //represents serialization between customer object and customer table 

    public DbSet<Order> Orders { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Store> Stores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      //connection string
      builder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=StoreApplicationDB;user id=sqladmin;password=Password12345;")
      //"server=;..." is the connection string
      //do not push with id and password 
    }
  }
}