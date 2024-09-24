using Practice5.Task2;
using System;
using System.Collections.Generic;

namespace Practice7.Task1.Model
{
  public class ListStorage<T> : IStorage<T>
  {
    #region Поля и свойства

    public static ConsoleLogger logger = new ConsoleLogger();

    /// <summary>
    /// Область хранения.
    /// </summary>
    private List<T> storage=new List<T>();

    /// <summary>
    /// Общее количество элементов в хранилище.
    /// </summary>
    public int Count
    {
      get
      {
        return storage.Count;
      }
    }


    #endregion

    #region Методы

    public void Add(T item)
    {
      this.storage.Add(item);
      logger.Info("Добавлен элемент в хранилище.");
    }

    public T Get(int index)
    {
      if (this.Count == 0)
      {
        throw new IndexOutOfRangeException("В хранилище нет данных.");
      }
      if (this.Count - 1 > index || index < 0)
      {
        throw new IndexOutOfRangeException("Индекс находится вне диапазона.");
      }

      return this.storage[index];
    }

    #endregion

    #region Конструкторы

    public ListStorage() 
    {
      logger.Info("Создан экземпляр класса ListStorage");
    }

    #endregion

  }
}
