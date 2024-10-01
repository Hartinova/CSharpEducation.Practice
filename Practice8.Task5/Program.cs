using System;

namespace Practice8.Task5
{
  internal class Program
  {
    private static System.Windows.Forms.Timer timer;
    static void Main(string[] args)
    {
      var timer = new Model.Timer();
      timer.Tick += PrintTime;

      for (int i = 0; i < 10; i++)
      {
        System.Threading.Thread.Sleep(1000);
        timer.Timer_Tick();       
      }

      Console.ReadLine();
    }
    private static void PrintTime()
    {
      Console.WriteLine("Текущее время: " + DateTime.Now);
    }
  }
}
