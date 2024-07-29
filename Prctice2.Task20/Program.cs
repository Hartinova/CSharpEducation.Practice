using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task20
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[,] array = CreateArray(5, 4);

      Console.WriteLine("Начальный массив:");
      PrintArray(array);

      Console.WriteLine("Массив с разницей максимального и минимального значений в каждой строке исходного массива:");
      PrintArray(GetArrayDifferenceRow(array));

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
      int[,] result = new int[length1, length2];
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
      for (int i = 0; i < array.GetLength(0); i++)
      {
        var row = string.Empty;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          row += array[i, j] + " ";
        }
        Console.WriteLine(row);
      }
    }

    /// <summary>
    /// Вывести массив на экран.
    /// </summary>
    /// <param name="array">Массив.</param>
    static void PrintArray(int[] array)
    {
      var row = string.Empty;
      for (int i = 0; i < array.GetLength(0); i++)
      {
        row += array[i] + " ";
      }
      Console.WriteLine(row);
    }

    /// <summary>
    /// Получить массив, заполненных разницей максимального и минимального значений строк исходного мсассива.
    /// </summary>
    /// <param name="length1">Количество строк.</param>
    /// <param name="length2">Количество колонок.</param>
    /// <returns>Созданный массив с заданной размерностью.</returns>
    static int[] GetArrayDifferenceRow(int[,] array)
    {
      int[] result = new int[array.GetLength(0)];

      for (int i = 0; i < array.GetLength(0); i++)
      {
        int min = array[i, 0];
        int max = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (min > array[i, j])
          {
            min = array[i, j];
          }
          if (max < array[i, j])
          {
            max = array[i, j];
          }
        }
        result[i] = max - min;
      }

      return result;
    }
  }
}
