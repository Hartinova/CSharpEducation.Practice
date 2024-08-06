using System;

namespace Practice3.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var student = new Student("Иван", 18);

      student.PrintInformationToConsole();
      Console.ReadLine();
    }
  }
}
