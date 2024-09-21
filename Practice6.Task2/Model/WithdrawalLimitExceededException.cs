using System;

namespace Practice6.Task2.Model
{
  /// <summary>
  /// Ошибка превышения лимита за месяц.
  /// </summary>
  public class WithdrawalLimitExceededException:Exception
  {
    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message"></param>
    public WithdrawalLimitExceededException() : base() { }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message"></param>
    public WithdrawalLimitExceededException(string message) :base(message){ }

    #endregion
  }
}
