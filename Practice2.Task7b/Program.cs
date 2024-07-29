using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task7b
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Программа для перевода строки в нижний регистр.");

      Console.WriteLine("Введите строку:");
      var text = Console.ReadLine();

      var newText = text.ToLower();

      Console.WriteLine("Новая строка:");
      Console.WriteLine(newText);

      Console.ReadLine();
    }
  }
}
