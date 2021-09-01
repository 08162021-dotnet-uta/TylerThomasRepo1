using System.Collections.Generic;
using System.Collections.Generic.List;
using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;

//Some guidance from https://docs.microsoft.com/en-us/ef/core/
//needs handler (context) to understand relation between C# objects and SQL objects

namespace Project0.StoreApplication.Storage.Adapters
{
  public class DataAdapter : DbContext //adapter needs to leverage that context 
  {
    //entities we have created 
    public DbSet<Customer> Customers { get; set; } //we are telling handler that there should be a set of customer instances 
    public DbSet<Order> Orders { get; set; } //we are telling handler that there should be a set of order instances 
    public DbSet<Product> Products { get; set; } //we are telling handler that there should be a set of product instances 
    public DbSet<Store> Stores { get; set; } //we are telling handler that there should be a set of store instances 

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=StoreApplicationDB;user id=sqladmin;password=Password12345;Trusted_Connection=true;");
      //change server data 
    }
  }
}