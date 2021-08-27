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
  public sealed class ProductSingleton
  {
    private static ProductSingleton _productSingleton;
    private static readonly ProductRepository _productRepository = new ProductRepository();

    public List<Product> Products { get; private set; }
    public static ProductSingleton Instance
    {
      get
      {
        if (_productSingleton == null)
        {
          _productSingleton = new ProductSingleton();
        }

        return _productSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private ProductSingleton()
    {
      Products = _productRepository.Select();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Product"></param>
    public void Add(Product product)
    {
      _productRepository.Insert(product);
      Products = _productRepository.Select();
    }
  }
}