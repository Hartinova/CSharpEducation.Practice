namespace Practice3.Task7
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var count = GetNumberDaysInMonth(Month.February, 2024);
    }

    /// <summary>
    /// Получить количество дней в месяце.
    /// </summary>
    /// <param name="month">Месяц.</param>
    /// <param name="year">Год - требуется для определения количества дней в феврале.</param>
    /// <returns></returns>
    public static int GetNumberDaysInMonth(Month month, int year = 0)
    {
      switch (month)
      {
        case Month.January:
        case Month.March:
        case Month.May:
        case Month.July:
        case Month.August:
        case Month.October:
        case Month.December: return 31;
        case Month.April:
        case Month.June:
        case Month.September:
        case Month.November: return 30;
        case Month.February:
          {
            if (year % 4 == 0)
            {
              return 29;
            }
            else
            {
              return 28;
            }
          }
        default: return 31;
      }
    }
  }
}
