using System;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;


namespace Project0.StoreApplication.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger;
      var program = new Program();

      program.CaptureOutput();
    }
    private void OutputStores()
    {
      Log.Information("method output stores");
      var StoreRepository = new StoreRepository();
      // output store location to user
      foreach (var store in storeRepository.Stores)
      {
        Console.WriteLine(store);
      }
    }

    private int CaptureInput()
    {
      Log.Information("in method capturing input");
      OutputStores();
      Console.WriteLine("Please select a store: ");

      // capture customer input
      int selected = int.Pasrse(Console.ReadLine());

      return selected;
    }

    private void CaptureOutput()
    {
      var StoreRepository = new StoreRepository();
      // output customer's selection
      Console.WriteLine("You have selected: " + " " + StoreRepository.stores[CaptureInput()]);
    }
  }
}
