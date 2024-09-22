using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task19
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] array=CreateArray(10);

      Console.WriteLine("Массив:");
      PrintArray(array);

      int difference = array.Max()- array.Min();

      Console.WriteLine($"Разница максимального и минимального значений = {difference}.");
      Console.ReadLine();
    }

    /// <summary>
    /// Создать массив, заполненных случайными числами.
    /// </summary>
    /// <param name="length">Размер массива.</param>
    /// <returns>Созданный массив с заданной размерностью.</returns>
    static int[] CreateArray(int length)
    {
      int[] result = new int[length];
      Random rnd = new Random();

      for (int i = 0; i < length; i++)
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
      var row = string.Empty;
      for (int i = 0; i < array.GetLength(0); i++)
      {
        row += array[i] + " ";
      }
      Console.WriteLine(row);
    }
  }
}
