using System;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class FileAdapter
  {
    public void List<Stores> ReadFromFile()
    {
      // file path
      string path = @"//revature/tyler_repo/data/project_0.xml";
      // open file
      var file = new StreamReader(path);
      // serialize object 
      var xml = new XmlSerializer(typeof(Store));
      // write to file
      var stores = xml.Deserialize(file) as List<Stores>;
      // close file 
      file.Close();
      // return data 
      return stores;
    }

    public void WriteToFile(List<Stores> stores)
    {
      // file path
      string path = @"//revature/tyler_repo/data/project_0.xml";
      // open file
      var file = new StreamWriter(path);
      // serialize object 
      var xml = new XmlSerializer(typeof(List<Stores>));
      // write to file
      xml.Serialize(file, stores);
      // close file 
      file.Close();
      // return data 
    }
  }
}