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

//runtime monitoring information gleaned from https://youtu.be/SqxvleC0L4g
// dotnet counters ps shows all programs that can be monitored
// dotnet counters monitor -p 8572 shows System.Runtime

namespace Project0.StoreApplication.Client
{
  public class Program
  {
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static readonly OrderSingleton _orderSingleton = OrderSingleton.Instance;

    private const string _myLogFilePath = @"revature/tyler_repo/data/logs.txt";

    private static void Run()
    {
      Log.Information("Method: Run()");

      if (_customerSingleton.Customers.Count == 0)
      {
        _customerSingleton.Add(new Customer());
      }
      Console.WriteLine(customer);
      var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
      var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];
      var order = _orderSingleton.Orders[Capture<Order>(_orderSingleton.Orders)];
      var product = _productSingleton.Orders[Capture<Product>(_productSingleton.Products)];


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
  }
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

    XmlSerializer serializer = new XmlSerializer(typeof(Customer));
    using (TextWriter tw = new StreamWriter(@"\revature\tyler_repo\projects\project_0\C#Data\customerClient.xml"))
    {
      serializer.serialize(tw, customerClient);
    }

    customerClient = null; //nullified because this information has been saved 
    XmlSerializer deserializer = new XmlSerializer(typeof(Customer));
    TextReader reader = new StreamReader("\revature\tyler_repo\projects\project_0\C#Data\customerClient.xml");
    object obj = deserializer.Deserialize(reader);
    customerClient = (Customer)obj;
    reader.Close();
    Console.WriteLine(customerClient.ToString);

    //HelloSQL();
  }
}


