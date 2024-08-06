using System;
using System.Text;

namespace Practice3.Task1
{
  /// <summary>
  /// Студент.
  /// </summary>
  public class Student
  {
    /// <summary>
    /// Минимальное значение среднего балла.
    /// </summary>
    private const double MinAverageScore = 0;

    /// <summary>
    /// Максимальное значение среднего балла.
    /// </summary>
    private const double MaxAverageScore = 5;

    /// <summary>
    /// Имя.
    /// </summary>
    private string name;

    /// <summary>
    /// Возраст.
    /// </summary>
    private int age;
    
    public Student(string name, int age)
    {
      this.name = name;
      this.age = age;
    }

    /// <summary>
    /// Вывести информацию о студенте в консоль.
    /// </summary>
    public void PrintInformationToConsole()
    {
      StringBuilder information = new StringBuilder();

      information.AppendLine($"Имя: {this.name}");
      information.AppendLine($"Возраст: {this.age}");

      Console.WriteLine(information.ToString());
    }
  }
}
