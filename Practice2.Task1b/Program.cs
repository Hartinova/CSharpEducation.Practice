using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task1b
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int kmToM = 1000;
      Console.WriteLine("Программа перевода метров в километры.");
      Console.WriteLine("Введите величину в метрах:");
      var valueM = Console.ReadLine();
      if(double.TryParse(valueM, out var val)) 
      {
        double valueKm = val / kmToM;
        Console.WriteLine($"{valueM} м = {valueKm} км");
      }
      else
      { 
        Console.WriteLine("Неверный формат входных данных.");
      }
      Console.ReadLine();
    }
  }
}
