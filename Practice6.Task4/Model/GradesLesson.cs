using Practice5.Task2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task4.Model
{
  /// <summary>
  /// Оценки за предмет.
  /// </summary>
  public class GradesLesson
  {
    #region Поля и свойства

    public static ConsoleLogger logger = new ConsoleLogger();

    /// <summary>
    /// Урок.
    /// </summary>
    public string Lesson { get; private set; }

    /// <summary>
    /// Пользователь.
    /// </summary>
    public string User { get; private set; }

    /// <summary>
    /// Оценки.
    /// </summary>
    public List<short> Grades { get; private set; }

    #endregion 

    #region Методы

    /// <summary>
    /// Получить оценки за предмет из файла.
    /// </summary>
    /// <param name="pathFile">Путь к файлу.</param>
    /// <exception cref="FileNotFoundException">Ошибка возникает, если файл не найден.</exception>
    /// <exception cref="NotSupportedException">Ошибка возникает, если файл неверного формата.</exception>
    /// <exception cref="ArgumentNullException">Ошибка возникает, если найдена пустая строка.</exception>
    /// <exception cref="InvalidCastException">Ошибка возникает, если не удается преобразовать строку в число.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Ошибка возникает, если число из файла за границами допустимого диапазона.</exception>
    public bool GetGradesFromFile(string pathFile)
    {
      Grades = new List<short>();

      logger.Info($"Загрузка оценок из файла {pathFile}.");
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
        StreamReader sr = null;
        try
        {
          sr = new StreamReader(pathFile);

          string line = sr.ReadLine().Trim();

          while (line != null)
          {
            if (line == "")
            {
              throw new ArgumentNullException("В файле пустая строка.");
            }

            if (short.TryParse(line, out short grade))
            {
              if (grade <= 0 || grade > 5)
              {
                throw new ArgumentOutOfRangeException($"Оценка {grade} за пределами допустимых значений.");
              }
              Grades.Add(grade);

              logger.Info($"{this.User} {this.Lesson} {grade}");
            }
            else
            {
              throw new InvalidCastException($"Не удается преобразовать строку '{line}' в число.");
            }


            line = sr.ReadLine();
          }
        }
        finally
        {
          sr?.Close();
        }
        return true;
      }
      catch
      {
        throw;
      }

    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструткор.
    /// </summary>
    /// <param name="lesson">Предмет.</param>
    /// <param name="user">Пользователь.</param>
    public GradesLesson(string lesson, string user)
    {
      this.Lesson = lesson;
      this.User = user;

      logger.Info($"Создана запись по предмету {lesson} для {user}.");
    }

    #endregion
  }
}
