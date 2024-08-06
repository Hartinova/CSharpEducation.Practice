using System;

namespace Practice3.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var student = new Student("Иван", 18, 4);

      student.PrintInformationToConsole();
      Console.ReadLine();
    }

    
  }
}
