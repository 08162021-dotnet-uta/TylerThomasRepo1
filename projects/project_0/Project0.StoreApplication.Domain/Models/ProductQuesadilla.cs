using System;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{
  public class ProductQuesadilla : Products
  {
    public ProductQuesadilla()
    {
      Name = "quesadilla";
      string productChoice3 = Console.ReadLine();
    }
  }
}