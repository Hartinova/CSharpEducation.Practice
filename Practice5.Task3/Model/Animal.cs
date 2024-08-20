using System;

namespace Practice5.Task3.Model
{
  /// <summary>
  /// Животное.
  /// </summary>
  public class Animal
  {
    /// <summary>
    /// Имя.
    /// </summary>
    public string Name {  get; private set; }

    /// <summary>
    /// Возраст.
    /// </summary>
    public int Age { get; private set; }

    /// <summary>
    /// Вывести сообщение, что животное кушает.
    /// </summary>
    public void Eat()
    {
      Console.WriteLine($"Animal {Name} is eating");
    }

    /// <summary>
    /// Вывести сообщение, что животное спит.
    /// </summary>
    public void Sleep()
    {
      Console.WriteLine($"Animal {Name} is sleeping");
    }

    /// <summary>
    /// Вывести звук.
    /// </summary>
    public virtual void MakeSound()
    {
      Console.WriteLine($"Some generic animal {Name} sound");
    }

    public Animal(string name, int age)
    {
      this.Name = name;
      this.Age = age;
    }
  }
}
