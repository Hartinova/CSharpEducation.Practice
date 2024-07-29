using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task4c
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Программа для прорисовки треугольника.");

      Console.WriteLine("Введите символ для построения треугольника:");
      var symbol=Console.ReadLine();

      Console.WriteLine("Введите высоту треугольника:");
      var input = Console.ReadLine();
      if (int.TryParse(input, out int height) && height > 0)
      {
        for (int i = 1; i <= height; i++)
        {
          var line = string.Empty;
          if (i < height)
          {
            for (int j = 1; j <= height - i; j++)
            {
              line += " ";
            }
          }
          for (int j = height - i + 1; j <= height; j++)
          {
            line += symbol;
          }
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
