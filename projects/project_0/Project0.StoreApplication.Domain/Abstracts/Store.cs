using System.Collections.Generic;
using System;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
  [XmlInclude(typeof(Chipotle1))]
  [XmlInclude(typeof(Chipotle2))]
  [XmlInclude(typeof(Chipotle3))]
  public class Store
  {
    string storeName1;
    string storeName2;
    string storeName3;
    public int StoreId { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
    public List<Product> Products { get; set; }

    public Store()
    {
      Orders = new List<Order>();
      Products = new List<Product>();
    }

    public string Chipotle1()
    {
      storeName1 = "Chipotle Kennesaw";
      string storeChoice1 = Console.ReadLine();
      return storeName1;
    }

    public string Chipotle2()
    {
      storeName2 = "Chipotle Marietta";
      string storeChoice2 = Console.ReadLine();
      return storeName2;
    }

    public string Chipotle3()
    {
      storeName3 = "Chipotle Woodstock";
      string storeChoice3 = Console.ReadLine();
      return storeName3;
    }

    public string SelectAStore()
    {
      //this is where a customer chooses a location
      Console.WriteLine("Please select a location: \n Chipotle Kennesaw \n Chipotle Marietta \n Chipotle Woodstock");
      string userStoreChoice = Console.ReadLine();

      Console.WriteLine("Your current store is: " + userStoreChoice);
      return userStoreChoice;
    }

    public static void ViewStorePastPurchases(string customerPurchase)
    {
      string[] menuItems = { "quesadilla", "salad", "burrito" };
      menuItems[0] = ("quesadilla");
      menuItems[1] = ("salad");
      menuItems[2] = ("burrito");

      Console.WriteLine("From the store viewpoint: ");

      for (int i = 0; i < menuItems.Length; i++)
        Console.WriteLine("Enter {0} to select {0}", i, menuItems[i]);
      string choice = Console.ReadLine();
      int j = int.Parse(choice);
      Console.WriteLine("Customer has selected {1}", j, menuItems[j]);
      Console.ReadLine();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }


  }
}