using System;

namespace Practice5.Task3.Model
{
  /// <summary>
  /// Кошка.
  /// </summary>
  public class Cat:Animal
  {
    public override void MakeSound()
    {
      Console.WriteLine("Meow");
    }

    public Cat() : this("", 0) { }

    public Cat(string name, int age) : base(name, age)
    {
      Console.WriteLine($"Создана кошка {name} с возрастом {age}");
    }
  }
}
