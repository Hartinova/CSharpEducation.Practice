namespace Practice3.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Point point1 = new Point(13, 5);
      Point point2 = new Point(1, 5);

      var res = Point.Distance(point1, point2);
    }
  }
}
