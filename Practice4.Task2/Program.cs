using MathLibrary;

namespace Practice4.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var sum = MathHelper.Sum(3.12, 5.33);
      var minus = MathHelper.Minus(13.1, 5);
      var multiplicate = MathHelper.Multiplicate(3.12, 5.33);
      var device = MathHelper.Divise(3.12, 5.33);
    }
  }
}
