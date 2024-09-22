using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task8
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите значение числовой переменной a:");
      var inputA = Console.ReadLine();

      Console.WriteLine("Введите значение числовой переменной b:");
      var inputB = Console.ReadLine();

      Console.WriteLine("Введите значение числовой переменной c:");
      var inputC = Console.ReadLine();

      int a;
      int b;
      int c;

      if (!int.TryParse(inputA, out a) || !int.TryParse(inputB, out b) || !int.TryParse(inputC, out c))
      {
        Console.WriteLine("Неверный формат входных данных.");
        Console.ReadLine();
        return;
      }

      if (a == b || a == c || b == c)
      {
        int d = 5;
        a += d;
        b += d;
        c += d;

        Console.WriteLine($"Новые значения переменных: a = {a} , b = {b} , c = {c}");
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Равных нет.");
        Console.ReadLine();
      }

    }
  }
}
