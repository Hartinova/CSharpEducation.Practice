using System;

namespace Practice3.Task10
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Car car = new Car("Шкода");
      Car.PrintStampToConsole(car);
      Console.ReadLine();
    }
  }
}
