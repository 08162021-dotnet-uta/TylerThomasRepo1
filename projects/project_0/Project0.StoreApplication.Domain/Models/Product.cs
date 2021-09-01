using System;

namespace Project0.StoreApplication.Domain.Models
{
  public class Product
  {
    string productName1;
    string productName2;
    string productName3;

    decimal burritoPrice;
    decimal saladPrice;
    decimal quesadillaPrice;

    public string ProductBurrito()
    {
      productName1 = "burrito";
      burritoPrice = 14.95m;
      string productChoice1 = Console.ReadLine();
      return productName1;
    }

    public decimal DisplayBurritoPrice()
    {
      burritoPrice = 14.95m;
      Console.WriteLine(burritoPrice);
      return burritoPrice;
    }
    public string ProductSalad()
    {
      productName2 = "salad";
      saladPrice = 12.95m;
      string productChoice4 = Console.ReadLine();
      return productName2;
    }

    public decimal DisplaySaladPrice()
    {
      saladPrice = 12.95m;
      Console.WriteLine(saladPrice);
      return saladPrice;
    }

    public string ProductQuesadilla()
    {
      productName3 = "quesadilla";
      quesadillaPrice = 10.95m;
      string productChoice3 = Console.ReadLine();
      return productName3;
    }

    public decimal DisplayQuesadillaPrice()
    {
      quesadillaPrice = 10.95m;
      Console.WriteLine(quesadillaPrice);
      return quesadillaPrice;
    }

    public string DisplayProducts() //edit to display price
    {
      //this is where they view what is available 
      string displayedProduct = "View products: \n Burrito \n Salad \n Quesadilla";
      Console.WriteLine(displayedProduct);
      return displayedProduct;
    }
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}