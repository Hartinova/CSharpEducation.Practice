namespace Practice7.Task2.Model
{
  /// <summary>
  /// Компания.
  /// </summary>
  public class Company
  {
    #region

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="name">Наименование.</param>
    public Company(string name)
    {
      this.Name = name;
    }

    #endregion
  }
}
