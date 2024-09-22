namespace Practice5.Task2
{
  /// <summary>
  /// Интерфейс логгирования.
  /// </summary>
  public interface ILogger
  {
    /// <summary>
    /// Записать шаг.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    void Trace(string message);

    /// <summary>
    /// Записать информацию.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    void Info(string message);

    /// <summary>
    /// Записать сообщение отладки.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    void Debug(string message);

    /// <summary>
    /// Записать предупреждение.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    void Warning(string message);

    /// <summary>
    /// Записать ошибку.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    void Error(string message);

    /// <summary>
    /// Записать фатальную ошибку.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    void Fatal(string message);

    /// <summary>
    /// Записать сообщение.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    /// <param name="logLevel">Тип сообщения.</param>
    void Log(string message, LogLevel logLevel);
  }
}
