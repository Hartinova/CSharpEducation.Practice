using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task15
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string[] array = new string[] { "в", "лесу", "родилась", "ёлочка" };
      Console.WriteLine("Исходный массив:");
      PrintArray(array);

      Console.WriteLine("Инвертированный массив:");
      PrintArray(InvertArray(array));

      Console.ReadLine();
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


    /// <summary>
    /// Инвертировать массив.
    /// </summary>
    /// <param name="array">Массив.</param>
    static string[] InvertArray(string[] array)
    {
      var result=new string[array.Length];

      int j = 0;
      for (int i = array.GetLength(0)-1; i >=0; i--)
      {
        result[j++] = array[i];
      }
     
      return result;
    }
  }
}
