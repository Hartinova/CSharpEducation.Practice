using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task1a
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var length = 5;
      var j = 0;
      var message = string.Empty;

      //a. Цикл for.
      Console.WriteLine("a. Цикл for");
      for (int i = 0; i < length; i++)
      {
        Console.WriteLine(i);
      }

      //b. Цикл while.
      Console.WriteLine("b. Цикл while");
      while (j < length)
      {
        Console.WriteLine(j++);
      }

      //c. Цикл do.. while.
      Console.WriteLine("c. Цикл do.. while");
      j = 0;
      do
      {
        Console.WriteLine(j++);
      }
      while (j < length);

      //d. Цикл for.
      Console.WriteLine("d. Цикл for");
      for (int i = 0; i < length; i++)
      {
        Console.WriteLine($"Введите {i} слово для сбора текста:");
        message += Console.ReadLine() + " ";
      }
      Console.WriteLine(message);

      //e. Цикл while.
      Console.WriteLine("e. Цикл while");
      message = string.Empty;
      j = 0;
      while (j < length)
      {
        Console.WriteLine($"Введите {j++} слово для сбора текста:");
        message += Console.ReadLine() + " ";
      }
      Console.WriteLine(message);

      //f. Цикл do.. while.
      Console.WriteLine("f. Цикл do.. while");
      j = 0;
      message = string.Empty;
      do
      {
        Console.WriteLine($"Введите {j++} слово для сбора текста:");
        message += Console.ReadLine() + " ";
      }
      while (j < length);
      Console.WriteLine(message);

      Console.ReadLine();
    }
  }
}
