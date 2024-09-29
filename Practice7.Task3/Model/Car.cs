namespace Practice7.Task3.Model
{
  /// <summary>
  /// Автомобиль.
  /// </summary>
  public class Car 
  {
    #region Поля и свойства

    /// <summary>
    /// Марка.
    /// </summary>
    public int Make { get; private set; }

    /// <summary>
    /// Модель.
    /// </summary>
    public string Model { get; private set; }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="make">Марка.</param>
    /// <param name="model">Модель.</param>
    public Car(int make, string model)
    {
      this.Make = make;
      this.Model = model;
    }

    #endregion
  }
}
