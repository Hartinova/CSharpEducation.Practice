using System;

namespace Practice6.Task3.Model
{
  /// <summary>
  /// Многократная ошибка записи.
  /// </summary>
  public class TooManyAttemptsException:Exception
  {
    public TooManyAttemptsException() : base() { }
    public TooManyAttemptsException(string message):base(message) { }
  }
}
