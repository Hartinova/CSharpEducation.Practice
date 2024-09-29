using Practice7.Task4.Model;
using System;
using System.Collections.Generic;

namespace Practice7.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var mylist = new MyList(new List<int> { 1, 2, 3, });

      foreach (var item in mylist)
      {
        Console.WriteLine(item);
      }


      var myDictionary = new MyDictionary(new List<string> { "rose", "apple", "car" });
      //myDictionary.Current=
      Console.WriteLine(myDictionary.Current);
      Console.WriteLine(myDictionary.MoveNext());
      Console.WriteLine(myDictionary.Current);
      Console.WriteLine(myDictionary.MoveNext());
      Console.WriteLine(myDictionary.Current);
      Console.WriteLine(myDictionary.MoveNext());
      Console.WriteLine(myDictionary.Current);
      myDictionary.Reset();
      Console.WriteLine(myDictionary.Current);

      var list = GetEvenNumbers(1, 13);
      foreach (var item in list)
      {
        Console.WriteLine(item);
      }

      Console.ReadLine();
    }

    /// <summary>
    /// Получить список четных числе из диапазона.
    /// </summary>
    /// <param name="numberFirst">Начало диапазона.</param>
    /// <param name="numberLast">Конец диапазона.</param>
    /// <returns>Массив четных чисел.</returns>
    public static IEnumerable<int> GetEvenNumbers(int numberFirst, int numberLast)
    {
      if (numberFirst % 2 != 0)
      {
        numberFirst++;
      }
      for (int i = numberFirst; i <= numberLast; i += 2)
      {
        yield return i;
      }
    }
  }
}
