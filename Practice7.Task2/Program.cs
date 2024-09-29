using Practice7.Task2.Model;
using System;

namespace Practice7.Task2
{
  public class Program
  {
    static void Main(string[] args)
    {
      var person = new Person("Oksana", 20, new Company("IRZ"));
      var personeClone=person.Clone();

      var rectangle = new Rectangle(2.34, 3.55);
      var rectangleClone=rectangle.Clone();
    }
  }
}
