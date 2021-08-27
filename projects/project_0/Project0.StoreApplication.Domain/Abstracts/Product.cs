using System;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Models
{
  [XmlInclude(typeof(ProductBurrito))]
  [XmlInclude(typeof(ProductChips))]
  [XmlInclude(typeof(ProductQuesadilla))]
  [XmlInclude(typeof(ProductSalad))]
  public abstract class Store
  {
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }
  }
  /*
  string quesadilla = "quesadilla";
  string salad = "salad";
  string burrito = "burrito";
  string chips = "chips";
  */

  /*public static string DisplayProducts()
  {
    Console.WriteLine("Please select a menu item: " + quesadilla + salad + burrito);
  }*/

  /*public static string OptionalChips()
  {
    Console.WriteLine("Would you like to add chips?");
    Console.WriteLine("Enter yes or no");
    string UserItemInput = Console.ReadLine();
    if (UserItemInput == "yes")
    {
      //add chips
    }
    else
    {
      //don't add chips 
    }
  }*/

}