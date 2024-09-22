using Practice5.Task2;
using Practice6.Task1.Model;
using System;
using System.IO;

namespace Practice6.Task1
{
  internal class Program
  {
    /// <summary>
    /// Логгер.
    /// </summary>
    public static ConsoleLogger logger=new ConsoleLogger();

    static void Main(string[] args)
    {
      bool exit = false;
      while (!exit)
      {
        Console.WriteLine("Введите путь к файлу. Для выхода введите 'exit'.");
        var line= Console.ReadLine();
        if (line == "exit")
        {
          return;
        }

        if (line.Trim() != "") 
        {
          try
          {
            logger.Info($"Частное: {Calculator.Divide(line)}");
          }
          catch(IOException ex)
          {
            logger.Error(ex.Message);
            logger.Info("Файл занят другим приложением. Освободите файл и попробуйте задать его снова.");
          }
          catch (Exception ex)
          {
             logger.Error(ex.Message);
          }
        }
        Console.WriteLine();
      }
      Console.ReadLine();
    }
  }
}
