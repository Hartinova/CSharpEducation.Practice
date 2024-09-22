using System;

namespace Practice3.Task10
{
  /// <summary>
  /// Автомобиль.
  /// </summary>
  public class Car
  {
    /// <summary>
    /// Марка.
    /// </summary>
    public string stamp;

    public Car(string stamp)
    {
      this.stamp = stamp;
    }

    /// <summary>
    /// Вывести марку автомобиля в консоль.
    /// </summary>
    /// <param name="car">Автомобиль.</param>
    public static void PrintStampToConsole(Car car)
    {
      Console.WriteLine(car.stamp);
    }
  }
}
