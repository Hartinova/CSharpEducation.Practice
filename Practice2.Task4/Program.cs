using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Программа для прорисовки треугольника.");

      Console.WriteLine("Введите высоту треугольника:");
      var input = Console.ReadLine();
      if (int.TryParse(input, out int height) && height > 0)
      {
        var line = string.Empty;
        for (int i = 1; i <= height; i++)
        {
          line += "*";
          Console.WriteLine(line);
        }
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
        Console.ReadLine();
      }

    }
  }
}
