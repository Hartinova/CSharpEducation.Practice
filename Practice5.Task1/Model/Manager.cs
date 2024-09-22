using Practice5.Task2;

namespace Practice5.Task1.Model
{
  /// <summary>
  /// Менеджер.
  /// </summary>
  public class Manager : Employee
  {
    /// <summary>
    /// Логгер.
    /// </summary>
    private static ConsoleLogger consoleLogger = new ConsoleLogger();

    /// <summary>
    /// Размер команды.
    /// </summary>
    public int TeamSize { get; private set; }

    public override double CalculateBonus()
    {
      if (TeamSize > 5)
      {
        return base.Salary * 0.25;
      }
      else
      {
        return base.Salary * 0.2;
      }
    }

    public Manager(string name, double sale, int teamSize) : base(name, sale)
    {
      this.TeamSize = teamSize;
      consoleLogger.Trace($"Создан менеджер {name}");
    }

    public Manager() : this("", 0, 0) { }

    public Manager(int teamSize) : this("", 0, teamSize) { }
  }
}
