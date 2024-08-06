using System;

namespace Practice3.Task5
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

    /// <summary>
    /// Год издания.
    /// </summary>
    private int yearPublication;

    /// <summary>
    /// Год издания.
    /// </summary>
    public int YearPublication
    {
      get
      {
        return yearPublication;
      }
      set
      {
        if (value < MinYear)
        {
          throw new ArgumentException($"Год издания должен быть >= {MinYear}.");
        }
        else
        {
          if (value > DateTime.Now.Year)
          {
            throw new ArgumentException($"Год издания не может быть > текущего.");
          }
          else
          {
            this.yearPublication = value;
          }
        }
      }

    }

    public Book(string title, string author, int yearPublication)
    {
      this.title = title;
      this.author = author;
      this.YearPublication = yearPublication;
    }

    public Book() : this("", "", MinYear) { }

    public Book(string title) : this(title, "", MinYear) { }

    public Book(string title, string author) : this(title, author, MinYear) { }
  }
}
