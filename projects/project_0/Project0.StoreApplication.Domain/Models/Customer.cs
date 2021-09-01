using System.Collections.Generic;
using System;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.Abstracts;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

//Guidance on serialization gleaned from https://youtu.be/jbwjbbc5PjI
//and https://www.c-sharpcorner.com/article/serializing-objects-in-C-Sharp/

namespace Project0.StoreApplication.Domain.Models
{
  public class Customer : ISerializable
  {
    public string customerPurchase;
    public byte CustomerId { get; set; } //property
    public string Name { get; set; } //property
    public List<Order> Orders { get; set; } //property

    [Serializable()]

    interface ISerializable
    {
      void Customer();
    }

    public Customer()
    {
      Name = "Tyler Thomas";
    }

    public override string ToString()
    {
      return $"{Name} with {Orders.Count} Orders so far";
    }

    public static void Purchase(string customerPurchase)
    {
      //this is where a customer should be able to purchase items

      Console.WriteLine("Please select a menu item: \n Burrito \n Salad \n Quesadilla");
      customerPurchase = Console.ReadLine();
      Console.WriteLine("You have added the following to your basket: " + customerPurchase);
    }

    public static void PastCustomerPurchases(string customerPurchase)
    {
      Console.WriteLine("Do you want to view the purchase(s) you just made? \n Enter 'yes' or 'no'");
      string userResponse = Console.ReadLine();

      Customer whatCustomerPurchased = new Customer();
      whatCustomerPurchased.customerPurchase = customerPurchase;

      if (userResponse == "yes")
      {
        Console.WriteLine("You have selected " + whatCustomerPurchased.customerPurchase);
      }
      if (userResponse == "no")
      {
        Console.WriteLine("Thank you for choosing us!");
      }
    }

    public void GetObjectDat(SerializationInfo info, StreamingContext context)
    {
      //SerializationInfo holds key value pairs for data
      //StreamingContext is supposed to hold additional information 
      info.AddValue("Name", Name);
      info.AddValue("customerPurchase", customerPurchase);
      info.AddValue("CustomerId", CustomerId);
      info.AddValue("Orders", Orders);
    }

    public Customer(SerializationInfo info, StreamingContext context)
    {
      //this segment allows us to retrieve files
      Name = (string)info.GetValue("Name", typeof(string));
      customerPurchase = (string)info.GetValue("customerPurchase", typeof(string));
      CustomerId = (byte)info.GetValue("CustomerId", typeof(byte));
      Orders = (List<>)info.GetValue("Name", typeof(List<>));
    }

    public static void Main(string[] args)
    {
      Store instanceOf = new Store();
      instanceOf.SelectAStore();

      Product anotherInstanceOf = new Product();
      anotherInstanceOf.DisplayProducts();

      Product instanceOfBurrPrice = new Product();
      instanceOfBurrPrice.DisplayBurritoPrice();

      Product instanceOfSaladPrice = new Product();
      instanceOfSaladPrice.DisplaySaladPrice();

      Product instanceOfQuesaPrice = new Product();
      instanceOfQuesaPrice.DisplayQuesadillaPrice();

      Customer lastInstanceOf = new Customer();
      //lastInstanceOf.Purchase(customerPurchase);

      Customer anotherNewInstance = new Customer();
      //anotherNewInstance.PastCustomerPurchases(customerPurchase);

      Store againAnInstance = new Store();
      //againAnInstance.ViewStorePastPurchases(customerPurchase);
    }
  }
}
