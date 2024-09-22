using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task6b
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Программа для расчета процента вхождения символа в строку.");

      Console.WriteLine("Введите строку:");
      var text = Console.ReadLine();

      Console.WriteLine("Введите символ:");
      var inputSymbol = Console.ReadLine();
      char symbol = inputSymbol[0];

      int count = 0;
      for (int i = 0; i < text.Length; i++)
      {
        if (text[i] == symbol)
        {
          count++;
        }
      }

      double percentageOccurrence = ((double)count / text.Length) * 100;

      Console.WriteLine($"Процент вхождения символа: {percentageOccurrence}");

      Console.ReadLine();
    }
  }
}
