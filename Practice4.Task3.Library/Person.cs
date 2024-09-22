using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4.Task3.Library
{
  /// <summary>
  /// Персона.
  /// </summary>
  public class Person
  {
    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get;private set; }

    /// <summary>
    /// Возраст.
    /// </summary>
    private int age;

    /// <summary>
    /// Возраст.
    /// </summary>
    public int Age
    {
      get
      {
        return age;
      }
      private set
      {
        if (value < 0)
        {
          throw new ArgumentException("Возраст не может быть отрицательным.");
        }
        else
        {
          age = value;
        }
      }
    }

    /// <summary>
    /// Вывести информацию о персоне на экран.
    /// </summary>
    public void PrintInformation()
    {
      Console.WriteLine($"Имя: {this.Name}");
      Console.WriteLine($"Возраст: {this.Age}");
      Console.ReadLine();
    }

    public Person(string name, int age)
    {
      this.Name = name;
      this.Age = age;
    }
  }
}
