using System;

namespace Practice3.Task4
{
  /// <summary>
  /// Книга.
  /// </summary>
  public class Book
  {
    /// <summary>
    /// Минимальный год.
    /// </summary>
    private const int MinYear = 1900;

    /// <summary>
    /// Название.
    /// </summary>
    private string title;

    /// <summary>
    /// Автор.
    /// </summary>
    private string author;

    public Book(string title, string author)
    {
      this.title = title;
      this.author = author;
    }

    public Book() : this("", "") { }
  }
}
