using System;

namespace Practice3.Task11
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Книга", "Иван");

      Console.WriteLine(Book.GetInformation(book));
      Console.ReadLine();
    }
  }
}
