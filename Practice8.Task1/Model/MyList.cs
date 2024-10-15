using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice8.Task1.Model
{
  /// <summary>
  /// Список целых чисел.
  /// </summary>
  public class MyList
  {
    /// <summary>
    /// Список целых чисел.
    /// </summary>
    List<int> list = new List<int>();

    /// <summary>
    /// Сортировать.
    /// </summary>
    /// <param name="comparison">Функция сравнения.</param>
    /// <exception cref="ArgumentNullException">Ошибка возникает, если не задана функция сравнения.</exception>
    public void Sort(Comparison<int> comparison)
    {
      if (comparison == null)
      {
        throw new ArgumentNullException("Не задана функция сравнения чисел.");
      }

      this.list.Sort(comparison);
    }

    /// <summary>
    /// Вывести список на экран.
    /// </summary>
    public void Print()
    {
      list?.ForEach(e=>System.Console.WriteLine(e));
      Console.WriteLine();
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="list">Список чисел.</param>
    public MyList(List<int> list)
    { 
      this.list = list; 
    }
  }
}
