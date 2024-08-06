using System;

namespace Practice3.Task3
{
  /// <summary>
  /// Калькулятор.
  /// </summary>
  public class Calculator
  {
    /// <summary>
    /// Сложить два числа.
    /// </summary>
    /// <param name="firstNumber">Первое чсило.</param>
    /// <param name="secondNumber">Второе число.</param>
    /// <returns></returns>
    public double Addition(double firstNumber, double secondNumber)
    {
      return firstNumber + secondNumber;
    }

    /// <summary>
    /// Вычесть из первого числа второе.
    /// </summary>
    /// <param name="firstNumber">Первое чсило.</param>
    /// <param name="secondNumber">Второе число.</param>
    /// <returns></returns>
    public double Subtraction(double firstNumber, double secondNumber)
    {
      return firstNumber - secondNumber;
    }

    /// <summary>
    /// Умножить два числа.
    /// </summary>
    /// <param name="firstNumber">Первое чсило.</param>
    /// <param name="secondNumber">Второе число.</param>
    /// <returns></returns>
    public double Multiply(double firstNumber, double secondNumber)
    {
      return firstNumber * secondNumber;
    }

    /// <summary>
    /// Разделить первое число на второе.
    /// </summary>
    /// <param name="firstNumber">Первое чсило.</param>
    /// <param name="secondNumber">Второе число.</param>
    /// <returns></returns>
    public double Divide(double firstNumber, double secondNumber)
    {
      if (secondNumber == 0)
      {
        throw new ArgumentException($"На 0 делить нельзя.");
      }

      return firstNumber / secondNumber;
    }
  }
}
