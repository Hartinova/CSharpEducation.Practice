using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task2c
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int kmToM = 1000;
      int hourToSec = 3600;
      Console.WriteLine("Программа перевода м/с в км/ч.");
      Console.WriteLine("Введите величину в м/с:");
      var valueMSec = Console.ReadLine();
      if (double.TryParse(valueMSec, out var val))
      {
        double valueKmHour = (val / kmToM) * hourToSec;
        Console.WriteLine($"{valueMSec} м/с = {valueKmHour} км/ч");
      }
      else
      {
        Console.WriteLine("Неверный формат входных данных.");
      }
      Console.ReadLine();
    }
  }
}
