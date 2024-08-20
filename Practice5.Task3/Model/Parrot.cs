using System;
using System.Diagnostics;

namespace Practice5.Task3.Model
{
  /// <summary>
  /// Попугай.
  /// </summary>
  public class Parrot : Animal, IFlyable
  {
    /// <summary>
    /// Цвет.
    /// </summary>
    public string Color { get; private set; }

    /// <summary>
    /// Вывести звук попугая.
    /// </summary>
    public new void MakeSound()
    {
      MakeSound("Parrot is talking");
    }

    /// <summary>
    /// Вывести строку.
    /// </summary>
    /// <param name="words">Строка, которую необходимо вывести.</param>
    private void MakeSound(string words)
    {
      Console.WriteLine(words);
    }

    public void Fly()
    {
      Console.WriteLine("Parrot is flying");
    }

    public Parrot() : this("", 0) { }

    public Parrot(string name, int age) : base(name, age) { }
  }
}
