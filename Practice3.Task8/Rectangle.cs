namespace Practice3.Task8
{
  /// <summary>
  /// Прямоугольник.
  /// </summary>
  public struct Rectangle
  {
    /// <summary>
    /// Ширина.
    /// </summary>
    public double width;

    /// <summary>
    /// Высота.
    /// </summary>
    public double height;

    public Rectangle(double width, double height)
    {
      this.width = width;
      this.height = height;
    }

    /// <summary>
    /// Получить площадь.
    /// </summary>
    /// <returns></returns>
    public double GetSquare()
    {
      return width * height;
    }
  }
}
