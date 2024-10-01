using Practice8.Task4.Model;
using System;
using System.Collections.Generic;

namespace Practice8.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var list = new List<string> { "asa","efgfwa" };
      var words=new Words(list);
      words.Print();

      words.SetConverter( str => str.ToUpper());
      words.Convert();

      words.Print();

      Console.ReadLine();
    }
  }
}
