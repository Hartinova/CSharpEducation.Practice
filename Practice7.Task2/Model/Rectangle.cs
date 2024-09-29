namespace Practice7.Task2.Model
{
  /// <summary>
  /// Прямоугольник.
  /// </summary>
  public class Rectangle
  {
    #region Поля и свойства

    /// <summary>
    /// Высота.
    /// </summary>
    public double Height { get;private set; }

    /// <summary>
    /// Ширина.
    /// </summary>
    public double Width { get;private set; }

    #endregion

    #region Методы

    /// <summary>
    /// Клонировать прямоугольник (поверхностное клонирование).
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
      return MemberwiseClone();
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="height">Высота.</param>
    /// <param name="width">Ширина.</param>
    public Rectangle(double height, double width)
    {
      this.Height = height;
      this.Width = width;
    }

    #endregion
  }
}
