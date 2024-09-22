using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Программа сравнения двух целых чисел.");

      int a;
      int b;

      Console.WriteLine("Введите 1 число:");
      var input = Console.ReadLine();
      if (!int.TryParse(input, out a))
      {
        Console.WriteLine("Неверный формат входных данных.");
        Console.ReadLine();
        return;
      }

      Console.WriteLine("Введите 2 число:");
      input = Console.ReadLine();
      if (!int.TryParse(input, out b))
      {
        Console.WriteLine("Неверный формат входных данных.");
        Console.ReadLine();
        return;
      }

      if (a == b)
      {
        Console.WriteLine($"{a} = {b}");
      }
      else
      {
        if (a > b)
        {
          Console.WriteLine($"{a} > {b}");
        }
        else
        {
          Console.WriteLine($"{a} < {b}");
        }
      }

      Console.ReadLine();
    }
  }
}
