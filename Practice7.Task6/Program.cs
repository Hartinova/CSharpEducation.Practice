using Practice7.Task6.Model;
using System;

namespace Practice7.Task6
{
  public class Program
  {
    static void Main(string[] args)
    {
      var str = "rjirf";
      Console.WriteLine(str.IsPalindrome());

      str = "оленисинело";
      Console.WriteLine(str.IsPalindrome());

      Console.WriteLine(str.ToTitleCase());

      Console.ReadLine();
    }
  }
}
