using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicce2.Task6a
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Программа для расчета процента вхождения символа в строку.");

      var text = "safafafsafwe retertetcx";
      Console.WriteLine($"Строка: {text}");

      var symbol = 's';
      Console.WriteLine($"Символ: {symbol}");

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
