using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task11
{
  internal class Program
  {
    static void Main(string[] args)
    {

      if (args.Length == 2)
      {
        var inputDim = args[0];
        var inputNumber = args[1];

        if (int.TryParse(inputDim, out var dim) && dim > 0 && int.TryParse(inputNumber, out var number))
        {
          var array = CreateArray(dim, number);
          Console.WriteLine("Массив:");
          PrintArray(array);
        }
        else
        {
          Console.WriteLine("Неверный формат входных данных.");
        }
      }
      Console.ReadLine();
    }

    /// <summary>
    /// Создать массив, заполненных случайными числами.
    /// </summary>
    /// <param name="lengthArray">Размер массива.</param>
    /// <param name="number">Число, которым заполняется массив.</param>
    /// <returns>Созданный массив с заданной размерностью.</returns>
    static int[] CreateArray(int lengthArray, int number)
    {
      int[] result = new int[lengthArray];

      for (int i = 0; i < lengthArray; i++)
      {
        result[i] = number;
      }

      return result;
    }

    /// <summary>
    /// Вывести массив на экран.
    /// </summary>
    /// <param name="array">Массив.</param>
    static void PrintArray(int[] array)
    {
      foreach (var item in array)
      {
        Console.WriteLine(item);
      }
    }
  }
}
