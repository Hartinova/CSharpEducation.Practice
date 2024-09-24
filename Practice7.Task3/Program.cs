using Practice7.Task3.Model;
using System;

namespace Practice7.Task3
{
  public class Program
  {
    static void Main(string[] args)
    {
      Book book1 = new Book("Книга", "Иванов");
      Book book2 = new Book("Книга", "Ивнаов");
      var res = book1.CompareTo(book2);

      Car car1 = new Car(3, "reno");
      Car car2 = new Car(1, "reno");
      Car car3 = new Car(2, "reno");
      Car[] cars = new Car[] {car1, car2, car3};

      Array.Sort(cars, new CarComparer());


    }
  }
}
