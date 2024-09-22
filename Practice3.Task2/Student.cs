using System;
using System.Text;

namespace Practice3.Task2
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

    /// <summary>
    /// Средний балл.
    /// </summary>
    private double averageScore;

    /// <summary>
    /// Средний балл.
    /// </summary>
    public double AverageScore
    {
      get
      {
        return this.averageScore;
      }
      set
      {
        if (value < MinAverageScore || value > MaxAverageScore)
        {
          throw new ArgumentException($"Средний балл должен быть в диапазоне от {MinAverageScore} до {MaxAverageScore}.");
        }
        else
        {
          this.averageScore = value;
        }
      }
    }

    public Student(string name, int age, double averageScore)
    {
      this.name = name;
      this.age = age;
      AverageScore = averageScore;
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
