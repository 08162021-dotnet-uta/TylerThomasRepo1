using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage;
using Serilog; //to serialize objects into binary format
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Project0.StoreApplication.Client
{
  public class Program
  {
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static readonly OrderSingleton _orderSingleton = OrderSingleton.Instance;

    private const string _myLogFilePath = @"revature/tyler_repo/data/logs.txt";

    private static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_myLogFilePath).CreateLogger();

      //HelloSQL();
    }

    private static void Run()
    {
      Log.Information("Method: Run()");

      if (_customerSingleton.Customers.Count == 0)
      {
        _customerSingleton.Add(new Customer());
      }

      var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
      var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];

      Console.WriteLine(customer);
    }

    private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"method: Output<{typeof(T)}>()");

      var index = 0;

      foreach (var item in data)
      {
        Console.WriteLine($"[{++index}] - {item}");
      }
    }

    private static int Capture<T>(List<T> data) where T : class
    {
      Log.Information("Method: Capture()");

      Output<T>(data);
      Console.Write("Make selection: ");

      int selected = int.Parse(Console.ReadLine());

      return selected - 1;
    }
    /*private static void HelloSQL()
    {
      var def = new DemoEF();

      def.SetCustomer(new Customer());

      foreach (var item in def.GetCustomers())
      {
        Console.WriteLine(item);
      }
    }*/

    public static void Main(string[] args)
    {
      Customer customerClient = new Customer("Nicholas", "salad", 1, 1);
      //to serialize object data to file
      Stream stream = File.Open("CustomerData.dat", FileMode.Create);
      //FileMode.Create essentially means if this doesn't exist then create it 
      BinaryFormatter bf = new BinaryFormatter();
      bf.Serialize(stream, customerClient);
      stream.Close();
      //to prove info has been saved 
      customerClient = null;
      stream = File.Open("CustomerData.dat", FileMode.Open);
      bf = new BinaryFormatter();
      customerClient = (Customer)bf.Deserialize(stream);
      stream.Close();
      Console.WriteLine(customerClient.ToString);
    }
  }
}

