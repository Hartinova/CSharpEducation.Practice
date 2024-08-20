using System;
using System.IO;

namespace Practice5.Task2
{
  public class FileLogger : ILogger
  {
    /// <summary>
    /// Путь к текстовому файлу с логами.
    /// </summary>
    public const string FilePath = "log.txt";

    public void Trace(string message)
    {
      Log(message, LogLevel.Trace);
    }

    public void Info(string message)
    {
      Log(message, LogLevel.Info);
    }

    public void Debug(string message)
    {
      Log(message, LogLevel.Debug);
    }

    public void Warning(string message)
    {
      Log(message, LogLevel.Warning);
    }

    public void Error(string message)
    {
      Log(message, LogLevel.Error);
    }

    public void Fatal(string message)
    {
      Log(message,LogLevel.Fatal);
    }

    public void Log(string message, LogLevel logLevel)
    {
      try
      {
        StreamWriter sw = new StreamWriter(FilePath);
        sw.WriteLine($"{DateTime.Now} | {this.GetType()} | {logLevel} | {message}");
        sw.Close();
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception: " + e.Message);
      }
    }
  }
}
