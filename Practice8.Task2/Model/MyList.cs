using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice8.Task2.Model
{
  /// <summary>
  /// Список строк.
  /// </summary>
  public class MyList
  {
    /// <summary>
    /// Список строк.
    /// </summary>
    List<string> list = new List<string>();

    /// <summary>
    /// Сортировать.
    /// </summary>
    /// <param name="predicate">Функция сравнения.</param>
    /// <exception cref="ArgumentNullException">Ошибка возникает, если не задана функция сравнения.</exception>
    public void FilterList(Predicate<string> predicate)
    {
      if (predicate == null)
      {
        throw new ArgumentNullException("Не задана функция для фильтра.");
      }

      this.list=this.list.Where(e=>predicate(e)).ToList();
    }

    /// <summary>
    /// Вывести список на экран.
    /// </summary>
    public void Print()
    {
      list?.ForEach(e => System.Console.WriteLine(e));
      Console.WriteLine();
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="list">список строк.</param>
    public MyList(List<string> list)
    {
      this.list = list;
    }
  }
}
