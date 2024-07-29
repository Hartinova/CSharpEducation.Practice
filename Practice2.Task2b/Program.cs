using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task2b
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int kmToCm = 100000;
      Console.WriteLine("Программа перевода километров в сантиметры.");
      Console.WriteLine("Введите величину в километрах:");
      var valueKm = Console.ReadLine();
      if (double.TryParse(valueKm, out var val))
      {
        double valueCm = val * kmToCm;
        Console.WriteLine($"{valueKm} км = {valueCm} см");
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
      }
      Console.ReadLine();
    }
  }
}
