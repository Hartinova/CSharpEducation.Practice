using System;

namespace Practice5.Task3.Model
{
  /// <summary>
  /// Собака.
  /// </summary>
  public class Dog: Animal
  {
    public override void MakeSound()
    {
      Console.WriteLine("Woof");
    }

    public Dog() : this("", 0) { }

    public Dog(string name, int age) : base(name, age) 
    {
      Console.WriteLine($"Создана собака {name} с возрастом {age}");
    }
  }
}
