using System;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{
  public class ProductChips : Products
  {
    public ProductChips()
    {
      Name = "chips";
      string productChoice2 = Console.ReadLine();
    }
  }
}