using System;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{
  public class ProductBurrito : Products
  {
    public ProductBurrito()
    {
      Name = "burrito";
      string productChoice1 = Console.ReadLine();
    }
  }
}