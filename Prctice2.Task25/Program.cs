using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task25
{
  internal class Program
  {
    /// <summary>
    /// Перечисление дней недели. 
    /// </summary>
    public enum DayOfWeek
    {
      Monday=1,
      Tuesday,
      Wednesday,
      Thursday,
      Friday,
      Saturday,
      Sunday
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Введите число от 1 до 7:");
      var inputNumber=Console.ReadLine();

      if (int.TryParse(inputNumber,out int number) && number > 0 && number < 7) 
      {
        Console.WriteLine(Enum.GetName(typeof(DayOfWeek), number));
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
      }

      Console.ReadLine();
    }
  }
}
