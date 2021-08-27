using System;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{
  public class ProductSalad : Products
  {
    public ProductSalad()
    {
      Name = "salad";
      string productChoice4 = Console.ReadLine();
    }
  }
}