using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task13
{
  internal class Program
  {
   static void Main(string[] args)
    {
      if (args.Length == 2)
      {
        var inputDim1 = args[0];
        var inputDim2 = args[1];

        if (int.TryParse(inputDim1, out var dim1) && dim1 > 0 && int.TryParse(inputDim2, out var dim2) && dim2 > 0)
        {
          var array = CreateArray(dim1, dim2);
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
    /// <param name="length1">Количество строк.</param>
    /// <param name="length2">Количество колонок.</param>
    /// <returns>Созданный массив с заданной размерностью.</returns>
    static int[,] CreateArray(int length1, int length2)
    {
      int[,] result = new int[length1,length2];
      Random rnd = new Random();

      for (int i = 0; i < length1; i++)
      {
        for (int j = 0; j < length2; j++)
        {
          result[i, j] = rnd.Next(1, 100);
        }
      }

      return result;
    }

    /// <summary>
    /// Вывести массив на экран.
    /// </summary>
    /// <param name="array">Массив.</param>
    static void PrintArray(int[,] array)
    {
      for (int i = 0; i < array.GetLength(0);i++)
      {
        var row = string.Empty;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          row += array[i, j] + " ";
        }
        Console.WriteLine(row);
      }
    }
  }
}
