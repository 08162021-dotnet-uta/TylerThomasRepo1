//For the creation of this code, I used
//https://youtu.be/C48b0idiINo as a source example.
//I will admit that this could be simpler and am open to suggestions.

using System;
using System.Collections.Generic;

namespace HelloCsharp
{
  class Program
  {

    static void Main()
    {
      int d = 9;
      int e = 8;
      int additionAnswer;
      int subtractionAnswer;
      int multiplicationAnswer;
      int divisionAnswer;


      additionAnswer = Add(d, e);
      subtractionAnswer = Sub(d, e);
      multiplicationAnswer = Mul(d, e);
      divisionAnswer = Div(d, e);

      Program w = new showResults(d, e);

      Console.ReadLine();
    }

    static public int Add(int d, int e)
    {
      int sum;
      sum = d + e;
      return sum;
    }

    static public int Sub(int d, int e)
    {
      int sub;
      sub = d - e;
      return sub;
    }

    static public int Mul(int d, int e)
    {
      int tim;
      tim = d * e;
      return tim;
    }

    static public int Div(int d, int e)
    {
      int quo;
      quo = d / e;
      return quo;
    }

    static public int showResults(int d, int e)
    {
      Console.WriteLine(Program.Add());
      Console.ReadLine();
      return 0;

      Console.WriteLine(Program.Sub());
      Console.ReadLine();
      return 0;

      Console.WriteLine(Program.Mul());
      Console.ReadLine();
      return 0;

      Console.WriteLine(Program.Div());
      Console.ReadLine();
      return 0;
    }

    private static int Div()
    {
      throw new NotImplementedException();
    }

    private static int Mul()
    {
      throw new NotImplementedException();
    }

    private static int Sub()
    {
      throw new NotImplementedException();
    }

    private static string Add()
    {
      throw new NotImplementedException();
    }
  }
}