using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task2d
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var koef1 = (double)9/5;
      int koef2 = 32;
      Console.WriteLine("Программа перевода градусов C в градусы F.");
      Console.WriteLine("Введите величину в градусах C:");
      var valueC = Console.ReadLine();
      if (double.TryParse(valueC, out var val))
      {
        double valueF = (val * koef1) +koef2;
        Console.WriteLine($"{valueC} C = {valueF} F");
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
      }
      Console.ReadLine();
    }
  }
}
