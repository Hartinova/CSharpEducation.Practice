using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task7c
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Программа делает первую букву в слове заглавной.");

      Console.WriteLine("Введите строку:");
      var text = Console.ReadLine();

      var newText = text.Substring(0,1).ToUpper()+text.Substring(1,text.Length-1).ToLower();
     
      Console.WriteLine("Новая строка:");
      Console.WriteLine(newText);

      Console.ReadLine();
    }
  }
}
