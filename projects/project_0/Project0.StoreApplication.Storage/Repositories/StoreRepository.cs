using System.Collections.Generic;
using System;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    //Store is the idea of the entity, not the definition 
    public List<Store> Stores { get; }

    public StoreRepository()
    {
      var fileAdapter = new FileAdapter();
      if (fileAdapter.ReadFromFile() = null)
      {
        fileAdapter.WriteToFile(new List<Stores>()
        {
          new Chipotle(),
          new Chipotle(),
          new Chipotle()
      });
      }
    }
    Stores = new List<Store>()

  }

  public Store GetStore(int index)
  {
    try
    {
      return s[index];
    }
    catch
    {
      return null;
    }

  }
}
}

