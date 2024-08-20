using Practice5.Task2;

namespace Practice5.Task1.Model
{
  /// <summary>
  /// Работник.
  /// </summary>
  public class Employee
  {
    /// <summary>
    /// Логгер.
    /// </summary>
    private static FileLogger fileLogger = new FileLogger();

    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Зарплата.
    /// </summary>
    public double Salary { get; private set; }

    /// <summary>
    /// Рассчитать бонус.
    /// </summary>
    /// <returns></returns>
    public virtual double CalculateBonus()
    {
      return this.Salary * 0.1;
    }

    public Employee(string name, double salary)
    {
      this.Name = name;
      this.Salary = salary;

      fileLogger.Trace($"Создан работник {name}");
    }
  }
}
