using Practice8.Task1.Model;
using System;
using System.Collections.Generic;

namespace Practice8.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var list = new List<int> { 2, 4, 1, 7, 0, 23, 4, 6 };

      var mylist = new MyList(list);
      mylist.Print();

      Comparison<int> comparison = sortUp;

      mylist.Sort(comparison);
      mylist.Print();

      mylist.Sort(sortDown);
      mylist.Print();

      Console.ReadLine();
    }

    public static int sortUp(int x,int y)
    { return x - y; }

    public static int sortDown(int x, int y)
    { return y - x; }
  }
}
