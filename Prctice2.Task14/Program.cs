using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task14
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите размер массива:");
      var inputDim=Console.ReadLine();
      if (int.TryParse(inputDim, out var dim) && dim>0)
      {
        var array=CreateArray(dim);
        for (int i = 0; i < dim; i++)
        {
          Console.WriteLine($"Введите {i} элемент массива:");
          array[i] = Console.ReadLine();
        }
        PrintArray(array);
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
      }

      Console.ReadLine();
    }

    /// <summary>
    /// Создать пустой массив.
    /// </summary>
    /// <param name="n">Размер массива.</param>
    /// <returns>Созданный массив с заданной размерностью.</returns>
    static string[] CreateArray(int n)
    {
      return new string[n];
    }

    /// <summary>
    /// Вывести массив на экран.
    /// </summary>
    /// <param name="array">Массив.</param>
    static void PrintArray(string[] array)
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
