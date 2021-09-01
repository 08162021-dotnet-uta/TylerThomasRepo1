using Xunit;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Storage.Adapters;
using System.Collections.Generic;
using System.Linq;
using System;

//using Microsoft.VisualStudio.TestTools.UnitTesting;
//Ideas for how to format this code gleaned from Jon Bukowsky and from
//https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code
//Code format also based off of Visual Studio built-in suggestions 
//dotnet test /p:CollectCoverage=true

namespace Project0.StoreApplication.Testing
{

  public class TestsForCustomerCS
  {
    private string testing = "/home/revature/tyler_repo/projects/project_0/";
    [Theory]

    public static Customer()
    {
      Name = "Tyler Thomas";
      return Name;
    }
    public void Test_PastCustomerPurchases()
    {
      Console.WriteLine("Do you want to view the purchase(s) you just made? \n Enter 'yes' or 'no'");
      string userResponse = Console.ReadLine();

      Customer whatCustomerPurchased = new Customer();
      whatCustomerPurchased.customerPurchase = customerPurchase;

      if (userResponse == "yes")
      {
        Console.WriteLine("You have selected " + whatCustomerPurchased.customerPurchase);
      }
      if (userResponse == "no")
      {
        Console.WriteLine("Thank you for choosing us!");
      }
    }
  }
}