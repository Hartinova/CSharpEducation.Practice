using Practice7.Task1.Model;
using System;

namespace Practice7.Task1
{
  public class Program
  {
    static void Main(string[] args)
    {
      var listStorage = new ListStorage<string>();
      listStorage.Add("привет");
      var item= listStorage.Get(0);

      Console.ReadLine();
    }
  }
}
