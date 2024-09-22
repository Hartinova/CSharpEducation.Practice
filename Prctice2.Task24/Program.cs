using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice2.Task24
{
  internal class Program
  {
    /// <summary>
    /// Перечисление дней недели. 
    /// </summary>
    public enum DayOfWeek
    {
      Monday,
      Tuesday,
      Wednesday,
      Thursday,
      Friday,
      Saturday,
      Sunday
    }

    static void Main(string[] args)
    {
      for (int i = 0; i < 7; i++)
      {
        Console.WriteLine( Enum.GetName(typeof(DayOfWeek), i)); 
      }

      Console.ReadLine();
    }
  }
}
