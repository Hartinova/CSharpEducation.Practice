using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double a;
      double b;
      double f;
     
      Console.WriteLine("Программа расчета выражения по формуле (а + b — f / а) + f * a * a — (a + b)");

      Console.WriteLine("Введите величину а:");
      var input = Console.ReadLine();
      if (!double.TryParse(input, out a))
      {
        Console.WriteLine("Неверный формат входных данных.");
        Console.ReadLine();
        return;
      }
      if (a == 0)
      {
        Console.WriteLine("На 0 делить нельзя.");
        Console.ReadLine();
        return;
      }

      Console.WriteLine("Введите величину b:");
      input = Console.ReadLine();
      if (!double.TryParse(input, out b))
      {
        Console.WriteLine("Неверный формат входных данных.");
        Console.ReadLine();
        return;
      }

      Console.WriteLine("Введите величину f:");
      input = Console.ReadLine();
      if (!double.TryParse(input, out f))
      {
        Console.WriteLine("Неверный формат входных данных.");
        Console.ReadLine();
        return;
      }

      double result = (a + b - f / a) + f * a * a - (a + b);

      Console.WriteLine($"При а = {a}, b = {b}, f = {f} результат выражения = {result}.");

      Console.ReadLine();
    }

   
  }
}
