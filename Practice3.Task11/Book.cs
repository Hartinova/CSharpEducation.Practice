namespace Practice3.Task11
{
  /// <summary>
  /// Книга.
  /// </summary>
  public class Book
  {

    /// <summary>
    /// Название.
    /// </summary>
    private string title;

    /// <summary>
    /// Автор.
    /// </summary>
    public string author;

    public Book(string title, string author)
    {
      this.title = title;
      this.author = author;
    }

    /// <summary>
    /// Получить информацию о книге.
    /// </summary>
    /// <param name="book">Книга.</param>
    /// <returns></returns>
    public static string GetInformation(Book book)
    {
      return $"Автор: {book.author}. Название: '{book.title}'.";
    }
  }
}
