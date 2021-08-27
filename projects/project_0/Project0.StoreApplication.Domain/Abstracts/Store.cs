using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
  [XmlInclude(typeof(Chipotle1))]
  [XmlInclude(typeof(Chipotle2))]
  [XmlInclude(typeof(Chipotle3))]
  public abstract class Store
  {
    public string Name { get; set; }

    public List<Order> Orders { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }
  }
}