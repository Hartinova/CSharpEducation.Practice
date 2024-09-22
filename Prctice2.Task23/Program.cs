using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task23
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите год:");
      var inputYear=Console.ReadLine();
      bool isLeapYear = false;

      if (int.TryParse(inputYear, out var year))
      {
        if (year % 400 == 0 || (!(year % 100 == 0) && (year % 4 == 0)))
        {
          isLeapYear = true;
        }
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
      }

      if (isLeapYear) 
      {
        Console.WriteLine($"Год {year} - високосный.");
      }
      else
      {
        Console.WriteLine($"Год {year} - невисокосный.");
      }

      Console.ReadLine();
    }
  }
}
