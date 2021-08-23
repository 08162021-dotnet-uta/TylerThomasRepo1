/*Topics discussed
Type inference (var)
Parsing
Casting (implicit, explicit)
Scopes (namespace, class, method, block)
Single responsibility (part of SOLID)
DRY (don't repeat yourself)
Method (signature, parameter, argument)
Primitive types (int, bool, string, float, double)
Type families ()
Method signature (access modifier, return type, identifier, optionally parameters, optionally non-access modifiers)
Exception handling 
*/
using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {

      // Output:
      // 012
      // for a calc, we need a way to input, compute and output values

      /* if (Input(out int input1, out int input2))
       {
         // to compute
         int result1 = Add(Input[0], Input[1]);
         int result2 = Subtract(Input[0], Input[1]);
         int result3 = Multiply(Input[0], Input[1]);
         int result4 = Divide(Input[0], Input[1]);
         Print(result1, result2, result3, result4);
       }*/

      int data = 10; //value type
      Int32 data2 = new Int32(); //reference type


      PassByValueNoBoxing(data);
      System.Console.WriteLine(data);

      PassByValueWithBoxing(ref data);
      System.Console.WriteLine(data);
    }

    static void PassByValueNoBoxing(int entry)
    {
      entry = 20;
    }

    static void PassByValueWithBoxing(int entry)
    {
      entry = 20;
    }
    static int Add(int input1, int input2)
    {
      // to compute
      return (int)input1 + (int)input2; //type inference, casting

      //parsing is taking the value from one type and finding the portion that becomes the new type 
      //casting is taking the entire type and converting it to the new type 
    }

    static int Subtract(int input1, int input2)
    {
      return (int)input1 - (int)input2;
    }

    static int Multiply(int input1, int input2)
    {
      return (int)input1 * (int)input2;

    }

    static int Divide(int input1, int input2)
    {
      return (int)input1 / (int)input2;
    }

    static void Print(params int[] results)
    {
      foreach (var result in results) //type inference; if int[] changed to a double, we'd have to go back to change a lot 
      {
        Console.WriteLine(result);
      }
    }

    static bool CustomTryParse(string s, out int result)
    {
      try
      {
        result = int.Parse(s);

        return true;
      }
      catch
      {
        result = 0;
        return false;
      }
    }

    static bool Input(out int i1, out int i2)
    {
      if (int.TryParse(Connsole.ReadLine(), out i1) && int.TryParse(Console.ReadLine(), out i2))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

  /*static int[] Input()
  {
    try
    {
      // to input 
      var input1 = int.Parse(Console.ReadLine()); //var in C# means the value will dictate the type 
      var input2 = int.Parse(Console.ReadLine()); //type inference, parsing 

      return new int[] { input1, input2 };
    }
    catch (Exception ex)
    {
      //throw ex;
      throw new Exception("We are sorry for the inconvenience.", ex);
    }
    finally
    {
      //always run

    }
  }*/
}

