

using Practice5.Task2;
using System;

namespace Practice6.Task3.Model
{
  /// <summary>
  /// Пользователь.
  /// </summary>
  public class User
  {
    #region Поля и свойства

    /// <summary>
    /// Логгер.
    /// </summary>
    public static ConsoleLogger logger = new ConsoleLogger();

    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Возраст.
    /// </summary>
    public int Age { get; private set; }

    /// <summary>
    /// Количество ошибок подряд при вводе возраста, при успешном обновлении возраста обнуляется.
    /// </summary>
    public int CountException { get; private set; }

    /// <summary>
    /// Максимальное количество попыток записи возраста.
    /// </summary>
    public static int maxCountExceptions = 5;

    #endregion

    #region Методы

    /// <summary>
    /// Проверить на совершеннолетие.
    /// </summary>
    /// <exception cref="Exception">Ошибка возникает, если пользователь несовершеннолетний.</exception>
    public void IsAdult()
    {
      try
      {
        if (this.Age < 18)
        {
          throw new Exception($"Пользователь {this.Name} несовершеннолетний.");
        }
      }
      catch (Exception)
      {
        throw;
      }

      logger.Info($"Пользователь {this.Name} совершеннолетний");
    }

    /// <summary>
    /// Изменить возраст.
    /// </summary>
    /// <param name="newAge">Новое значение возраста.</param>
    /// <exception cref="InvalidCastException">Ошибка возникает, если не удается преобразовать строку в число.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Ошибка возникает, если возраст выходит за диапазоны возможного.</exception>
    /// <exception cref="TooManyAttemptsException">Ошибка возникает, если превышено количество неправильного ввода возраста.</exception>
    public bool SetAge(string newValue)
    {
      try
      {
        if (this.CountException >= maxCountExceptions)
        {
          throw new TooManyAttemptsException($"Превышено количество ошибочных попыток записи возраста.");
        }
        if (!int.TryParse(newValue ,out int newAge))
        {
          throw new InvalidCastException($"Не удалось преобразовать '{newValue}' в число.");
        }        
        if (newAge < 0 || newAge > 150)
        {
          throw new ArgumentOutOfRangeException($"Некорректно указан возраст {newAge}.");
        }

        this.Age = newAge;
        this.CountException = 0;
        logger.Info($"Пользоваателю {this.Name} задан возраст {newAge}.");

        return true;
      }
      catch(Exception)
      {
        this.CountException++;
        throw;
      }
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    public User(string name, int age)
    {
      this.CountException = 0;
      this.Name = name;
      this.Age = age;
    
      logger.Info($"Создан пользователь с именем {this.Name} и возрастом {this.Age}.");    
    }
    #endregion
  }
}
