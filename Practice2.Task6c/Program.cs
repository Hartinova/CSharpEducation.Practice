using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task6c
{
  internal class Program
  {
    static void Main(string[] args)
    {
     
      if (args.Length == 2)
      { 
          var text = args[0];
          char symbol = args[1][0];

        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
          if (text[i] == symbol)
          {
            count++;
          }
        }

        double percentageOccurrence = ((double)count / text.Length) * 100;

        Console.WriteLine($"Процент вхождения символа '{symbol}' в строку '{text}': {percentageOccurrence}");

      }
      Console.ReadLine();
    }
  }
  
}
