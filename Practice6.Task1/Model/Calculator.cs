using Practice5.Task2;
using System;
using System.IO;

namespace Practice6.Task1.Model
{
  /// <summary>
  /// Калькулятор.
  /// </summary>
  public static class Calculator
  {
    #region Поля и свойства

    public static ConsoleLogger logger = new ConsoleLogger();

    #endregion

    #region Методы

    /// <summary>
    /// Разделить числа. Делимое - это первая строка из файла. Делитель - это вторая строка из файла.
    /// </summary>
    /// <param name="pathFile">Путь к файлу с числами.</param>
    /// <returns>Частное.</returns>
    /// <exception cref="FileNotFoundException">Ошибка возникает, если файл не найден.</exception>
    /// <exception cref="InvalidCastException">Ошибка возникает, если строку из файла не удается преобразовать в число.</exception>
    ///<exception cref="ArgumentNullException">Ошибка возникает,если на задано делимое или делитель</exception>
    /// <exception cref="DivideByZeroException">Ошибка возникает, если делитель = 0.</exception>
    /// <exception cref="NotSupportedException">Ошибка возникает, если задан файл неверного формата</exception>
    public static double Divide(string pathFile)
    {
      double dividend = 0;
      double divider = 0;

      try
      {
        if (!File.Exists(pathFile))
        {
          throw new FileNotFoundException($"Не найден файл {pathFile}.");
        }

        if (!pathFile.EndsWith(".txt"))
        {
          throw new NotSupportedException($"Файл {pathFile} неверного формата. Используются файлы типа *.txt.");
        }

        StreamReader sr = new StreamReader(pathFile);

        string line1 = sr.ReadLine();
        if (line1 == null || line1.Trim()=="")
        {
          throw new ArgumentNullException("В файле на задано делимое.");
        }

        if (!double.TryParse(line1, out dividend))
        {
          throw new InvalidCastException($"Не удается преобразовать '{line1}' в число.");
        }

        logger.Info($"Делимое {line1}");

        string line2 = sr.ReadLine();

        if (line2 == null || line2.Trim() == "")
        {
          throw new ArgumentNullException("В файле на задан делитель.");
        }

        if (!double.TryParse(line2, out divider))
        {
          throw new InvalidCastException($"Не удается преобразовать '{line2}' в число.");
        }

        logger.Info($"Делитель {line2}");

        if (divider == 0)
        {
          throw new DivideByZeroException("Делить на ноль нельзя.");
        }

        sr.Close();
      }
      catch
      {
        throw;
      }

      return dividend / divider;
    }

    #endregion

  }
}
