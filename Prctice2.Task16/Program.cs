using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task16
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите число:");
      var inputNumber = Console.ReadLine();
      if (int.TryParse(inputNumber, out var number))
      {
        ChangeSign(ref number);
        Console.WriteLine($"Число с противовположным знаком: {number}");
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
      }

      Console.ReadLine();
    }

    /// <summary>
    /// Изменить знак числа на противоположный.
    /// </summary>
    /// <param name="number">число</param>
    static void ChangeSign(ref int number)
    {
      if (number > 0)
      {
        number = -number;
      }
      else
      {
        number = number * (-1);
      }
    }
  }
}
