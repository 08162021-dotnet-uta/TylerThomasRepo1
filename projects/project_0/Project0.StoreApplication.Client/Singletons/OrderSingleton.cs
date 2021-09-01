using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

//singleton exists to manage interactions to repository 

//In this pattern, a class has only one instance in the program that provides a global point of access to it.
namespace Project0.StoreApplication.Client.Singletons
{
  public sealed class OrderSingleton
  {
    private static OrderSingleton _orderSingleton;
    private static readonly OrderRepository _orderRepository = new OrderRepository();

    public List<Order> Orders { get; private set; }
    public static OrderSingleton Instance
    {
      get
      {
        if (_orderSingleton == null)
        {
          _orderSingleton = new OrderSingleton();
        }

        return _orderSingleton;
      }
    }
    private OrderSingleton()
    {
      Orders = _orderRepository.Select();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="customer"></param>
    public void Add(Order order)
    {
      _orderRepository.Insert(order);
      Orders = _orderRepository.Select();
    }
  }
}