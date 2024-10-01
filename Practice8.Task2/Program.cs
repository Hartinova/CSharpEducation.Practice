using Practice8.Task2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var list = new List<string> { "кошка", "кот", "пес", "собака" };

      var mylist = new MyList(list);
      mylist.Print();

      Predicate<string> predicate = filterLength3;

      mylist.FilterList(predicate);
      mylist.Print();

      mylist.FilterList(filterExistStr);
      mylist.Print();

      Console.ReadLine();
    }

    public static bool filterLength3(string x)
    { return x.Length==3; }

    public static bool filterExistStr(string x)
    { return x.Contains("ко"); }
  }
}
