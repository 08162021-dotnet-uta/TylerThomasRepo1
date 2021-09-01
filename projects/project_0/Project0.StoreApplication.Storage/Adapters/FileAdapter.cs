using System.Collections.Generic;
using System.Collections.Generic.List;
using System.IO;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using System;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class FileAdapter
  {
    public List<Customer> ReadCustomers()
    {
      private readonly DataAdapter _da = new DataAdapter();
  }

  public List<Customer> GetCustomers()
  {
    return _da.Customers.FromSqlRaw("select * from Customer.Customer").ToList();
  }

  public List<Order> ReadOrders()
  {
      private readonly DataAdapter _da = new DataAdapter();
}

public List<Order> GetOrders()
{
  return _da.Orders.FromSqlRaw("select * from Store.[Order]").ToList();
}

public List<Product> ReadProducts()
{
        private readonly DataAdapter _da = new DataAdapter();
    }

    public List<Product> GetProducts()
{
  return _da.Products.FromSqlRaw("select * from Store.Product").ToList();
}

public List<Store> ReadStores()
{
      private readonly DataAdapter _da = new DataAdapter();
    }

    public List<Store> GetStores()
{
  return _da.Stores.FromSqlRaw("select * from Store.Store").ToList();
} 
}
}