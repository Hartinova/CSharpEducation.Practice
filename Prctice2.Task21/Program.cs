using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task21
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();
      int number = rnd.Next(1, 100);

      bool flagExit = false;
      Console.WriteLine("Угадайте загаданное число от 1 до 100. Для выхода из игры введите команду 'exit'");

      while (!flagExit)
      {
        var inputValue = Console.ReadLine();
        if (inputValue == "exit")
        {
          flagExit = true;
        }
        else
        {
          if (int.TryParse(inputValue, out int value))
          {
            if (number == value)
            {
              Console.WriteLine($"Вы угадали число! Это {value}. Мои поздравления!");
              flagExit = true;
            }
          }
          else
          {
            Console.WriteLine("Введите число от 1 до 100:");
          }
        }
      }
      Console.ReadLine();
    }
  }
}
