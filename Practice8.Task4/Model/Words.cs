using System;
using System.Collections.Generic;

namespace Practice8.Task4.Model
{
  /// <summary>
  /// Слова.
  /// </summary>
  public class Words
  {
    #region Поля и свойства

    /// <summary>
    /// Список слов.
    /// </summary>
    private List<string> list;

    /// <summary>
    /// Конвертер.
    /// </summary>
    private Func<string, object> converter;

    #endregion

    #region Методы

    /// <summary>
    /// Установить конвертер.
    /// </summary>
    /// <param name="converter">Конвертер.</param>
    /// <exception cref="ArgumentNullException">Ошибка возникает, если не задана функция преобразования.</exception>
    public void SetConverter(Func<string, object> converter)
    {
      if (converter==null)
      {
        throw new ArgumentNullException("Не задана функция преобразования.");
      }

      this.converter = converter;
    }

    /// <summary>
    /// Преобразовать список слов.
    /// </summary>
    public void Convert()
    {
      if (list==null || list.Count==0)
      {
        return;
      }

      for (int i = 0; i < list.Count; i++)
      {
        list[i] = converter(list[i]).ToString();
      }
    }

    /// <summary>
    /// Вывести список слов.
    /// </summary>
    public void Print()
    {
      if (list == null || list.Count == 0)
      {
        return;
      }

      foreach (var item in list)
      {
        Console.WriteLine(item);
      }
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="words">Список слов.</param>
    public Words(List<string> words)
    {
      this.list = words;
    }

    #endregion
  }
}
