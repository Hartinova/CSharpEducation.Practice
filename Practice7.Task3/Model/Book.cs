using System;

namespace Practice7.Task3.Model
{
  /// <summary>
  /// Книга.
  /// </summary>
  public class Book:IComparable
  {
    #region Поля и свойства

    /// <summary>
    /// Название.
    /// </summary>
    public string Title { get;private set; }

    /// <summary>
    /// Автор.
    /// </summary>
    public string Author { get;private set; }

    #endregion

    #region Методы

    /// <summary>
    /// Сравнить две книги по названию.
    /// </summary>
    /// <param name="otherBook">Книга, с которой сравниваем.</param>
    /// <returns>Результат сравнения.</returns>
    public int CompareTo(object obj)
    {
      if (obj is Book book)
      {
        return string.Compare(this.Title, book.Title);
      }
      else
      {
        throw new ArgumentException($"Сравнение с типом '{obj.GetType()}' не поддерживаетя.");
      }
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="title">Заголовок.</param>
    /// <param name="author">Автор.</param>
    public Book(string title, string author)
    {
      this.Title = title;
      this.Author = author;
    }

    #endregion
  }
}
