using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
  /// <summary>
  /// Математические функции.
  /// </summary>
  public static class MathHelper
  {
    /// <summary>
    /// Сложить 2 числа.
    /// </summary>
    /// <param name="x">Первое число.</param>
    /// <param name="y">Второе число.</param>
    /// <returns>Сумма двух чисел.</returns>
    public static double Sum(double x, double y)
    {
      return x + y;
    }

    /// <summary>
    /// Вычесть из 1 числа 2 число.
    /// </summary>
    /// <param name="x">Первое число.</param>
    /// <param name="y">Второе число.</param>
    /// <returns>Разность двух чисел.</returns>
    public static double Minus(double x, double y)
    {
      return x - y;
    }

    /// <summary>
    /// Произведение двух чисел.
    /// </summary>
    /// <param name="x">Первый множитель.</param>
    /// <param name="y">Второй множитель.</param>
    /// <returns>Произведение двух чисел.</returns>
    public static double Multiplicate(double x, double y)
    {
      return x * y;
    }

    /// <summary>
    /// Разделить 1 число на 2 число.
    /// </summary>
    /// <param name="x">Делимое.</param>
    /// <param name="y">Делитель.</param>
    /// <returns>Частное.</returns>
    public static double Divise(double x, double y)
    {
      return x / y;
    }
  }
}
