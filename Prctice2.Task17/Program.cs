using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task17
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите 1 число:");
      var inputNumber1 = Console.ReadLine();

      Console.WriteLine("Введите 2 число:");
      var inputNumber2 = Console.ReadLine();

      if (int.TryParse(inputNumber1, out var number1) && int.TryParse(inputNumber2, out var number2))
      {
        ChangeNumbers(ref number1,ref number2);
        Console.WriteLine($"Число 1: {number1}. Число 2: {number2}");
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
      }

      Console.ReadLine();
    }

    /// <summary>
    /// Изменить местами значения чисел;
    /// </summary>
    /// <param name="number1">Число 1.</param>
    /// <param name="number2">Число 2.</param>
    static void ChangeNumbers ( ref int number1, ref int number2)
    {
      var tmp = number1;
      number1 = number2;
      number2 = tmp;
    }
  }
}
