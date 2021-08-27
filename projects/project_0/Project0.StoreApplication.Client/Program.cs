using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Abstracts; //keep getting error that Domain does not exist in namespace
//How do I check for an Assembly reference and what is the best way of making one?
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

/*namespace Project0.StoreApplication.Client
{
  /// <summary>
  /// Defines the Program Class
  /// </summary>
  internal class Program
  {
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private const string _logFilePath = @"/home/tyler/revature/tyler_repo/data/logs.txt";

    /// <summary>
    /// Defines the Main Method
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      Run();
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Run()
    {
      Log.Information("method: Run()");

      if (_customerSingleton.Customers.Count == 0) //can the same be done for product?
      {
        _customerSingleton.Add(new Customer());
      }

      var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
      var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];
      var product = _productSingleton.Products[Capture<ProductRepository>(_productSingleton.Products)];
      // stores
      //Output<Store>(_storeSingleton.Stores);
      // products
      //Output<Product>(_productSingleton.Products);

      Console.WriteLine(customer);
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"method: Output<{typeof(T)}>()");

      var index = 0;

      foreach (var item in data)
      {
        Console.WriteLine($"[{++index}] - {item}");
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int Capture<T>(List<T> data) where T : class
    {
      Log.Information("method: Capture()");

      Output<T>(data);
      Console.Write("make selection: ");

      int selected = int.Parse(Console.ReadLine());

      return selected - 1;
    }
  }
}*/

namespace Project0.StoreApplication.Client
{
  class Program
  {
    public static void Main(string[] args)
    {
      SelectAStore();
      DisplayProducts();
      Purchase();
    }

    public static string SelectAStore()
    {
      //this is where a customer chooses a location
      Console.WriteLine("Please select a location: " + Chipotle1() + Chipotle2() + Chipotle3());
      Console.ReadLine();
      Console.WriteLine("Your current store is: " + storeChoice1 + storeChoice2 + storeChoice3);
    }
    public static string DisplayProducts()
    {
      //this is where they view what is available 
      Console.WriteLine("View products: " + ProductBurrito() + ProductChips() + ProductQuesadilla() + ProductSalad());
    }

    public static void Purchase()
    {
      //this is where a customer should be able to purchase items 
      Console.WriteLine("Please select a menu item: " + quesadilla + salad + burrito);
      //select X for Y
      Console.ReadLine();

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
    }

    public static void PastPurchases()
    {
      //display what was chosen in Purchase()

    }

  }
}

/*
a customer should be able to view set of store locations and select one (2pts) - getting there
a customer should be able to view available products to purchase (2pts) - getting there
a customer should be able to purchase at least 1 product (2pts) - getting there 
a customer should be able to view past purchase (2pts) - stuck
a store should be able to view past purchases (2pts) - stuck 
a solution containing 4 projects (Client, Domain, Storage, Testing) should be implemented (10pts) - getting there 
a test coverage of at least 50% should be implemented (10pts) - 
a data storage with serialization should be implemented (10pts) -
a runtime monitoring with logging should be implemented (10pts) -
*/

