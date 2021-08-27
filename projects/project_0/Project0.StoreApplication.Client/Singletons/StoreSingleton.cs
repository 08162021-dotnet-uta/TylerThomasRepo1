using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

//In this pattern, a class has only one instance in the program that provides a global point of access to it.
namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public sealed class StoreSingleton
  {
    private static StoreSingleton _storeSingleton;
    private static readonly StoreRepository _storeRepository = new StoreRepository();

    public List<Store> Stores { get; private set; }
    public static StoreSingleton Instance
    {
      get
      {
        if (_storeSingleton == null)
        {
          _storeSingleton = new StoreSingleton();
        }

        return _storeSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {
      Stores = _storeRepository.Select();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Store"></param>
    public void Add(Store store)
    {
      _storeRepository.Insert(store);
      Stores = _storeRepository.Select();
    }
  }
}