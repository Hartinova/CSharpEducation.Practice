using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task18
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] array = { 1, 2, -3, -4, 5, };
      Console.WriteLine("Массив на входе:");
      PrintArray(array);

      Console.WriteLine("Массив без отрицательных чисел:");
      var newArray = ArrayWithoutNegativeValues(array, out int countNegativeValues);
      PrintArray(newArray);

      Console.WriteLine($"Количество удаленных чисел: {countNegativeValues}");

      Console.ReadLine();
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
    /// Получить массив без отрицательных чисел.
    /// </summary>
    /// <param name="array">Изначальный массив.</param>
    /// <returns>Массив без отрицательных чисел.</returns>
    static int[] ArrayWithoutNegativeValues(int[] array, out int countDeleted)
    {
      countDeleted = array.Count(e => e < 0);
      return array.Where(e=>e>0).ToArray();
    }
  }
}
