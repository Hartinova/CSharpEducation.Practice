using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task10
{
  internal class Program
  {
    static void Main(string[] args)
    {

      if (args.Length == 1)
      {
        var inputDim = args[0];

        if (int.TryParse(inputDim, out var dim) && dim > 0)
        {
          var array = CreateArray(dim);
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
    /// <returns>Созданный массив с заданной размерностью.</returns>
    static int[] CreateArray(int lengthArray)
    {
      int[] result = new int[lengthArray];
      Random rnd = new Random();

      for (int i = 0; i < lengthArray; i++)
      {
        result[i] = rnd.Next(1, 100);
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
