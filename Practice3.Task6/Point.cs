using System;

namespace Practice3.Task6
{
  /// <summary>
  /// Точка.
  /// </summary>
  public struct Point
  {
    /// <summary>
    /// Координата Х.
    /// </summary>
    public int x;

    /// <summary>
    /// Координата Y.
    /// </summary>
    public int y;

    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    /// <summary>
    /// Определить расстояние между точками.
    /// </summary>
    /// <param name="firstPoint">Первая точка.</param>
    /// <param name="secondPoint">Вторая точка.</param>
    /// <returns></returns>
    public static double Distance(Point firstPoint, Point secondPoint)
    {
      return Math.Sqrt(Math.Pow((firstPoint.x - secondPoint.x), 2) + Math.Pow((firstPoint.y - secondPoint.y), 2));
    }
  }
}
