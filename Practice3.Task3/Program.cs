using System;

namespace Practice3.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var calculator = new Calculator();

      double x = 4;
      double y = 1;
      double result = calculator.Divide(x, y);

      Console.WriteLine(result);
      Console.ReadLine();
    }
  }
}
