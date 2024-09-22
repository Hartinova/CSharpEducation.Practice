using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task22b
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();
      int number = rnd.Next(1, 100);
      //Количество возможных попыток.
      int numberAttempts = 10;
      //Количество попыток, которое понадобилось пользователю.
      int numberAttemptsUser = 0;

      bool flagExit = false;
      Console.WriteLine("Угадайте загаданное число от 1 до 100. Для выхода из игры введите команду 'exit'");

      while (!flagExit)
      {
        Console.WriteLine($"Попытка {numberAttemptsUser + 1} из {numberAttempts}.");

        var inputValue = Console.ReadLine();
        if (inputValue == "exit")
        {
          flagExit = true;
        }
        else
        {
          numberAttemptsUser++;
          if (int.TryParse(inputValue, out int value))
          {
            if (number == value)
            {
              Console.WriteLine($"Вы угадали число c {numberAttemptsUser} попытки! Это {value}. Мои поздравления!");
              flagExit = true;
              Console.ReadLine();
              return;
            }
            else
            {
              if (value<number)
              {
                Console.WriteLine($"Загаданное число > {value}");
              }
              else
              {
                Console.WriteLine($"Загаданное число < {value}");
              }
            }
          }
          if (numberAttemptsUser == numberAttempts)
          {
            Console.WriteLine($"Вы проиграли. Истратили {numberAttempts} попыток.");
            flagExit = true;
          }
        }
      }
      Console.ReadLine();
    }
  }
}
