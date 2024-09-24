using System;

namespace Practice7.Task2.Model
{
  /// <summary>
  /// Личность.
  /// </summary>
  public class Person:ICloneable
  {
    #region Поля и свойства

    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get;private set; }

    /// <summary>
    /// Возраст.
    /// </summary>
    public int Age { get; private set; }

    /// <summary>
    /// Компания.
    /// </summary>
    public Company Work { get; private set; }

    #endregion

    #region Методы

    /// <summary>
    /// Клонировать личность (глубокое клонирование).
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
      return new Person(this.Name, this.Age, new Company(this.Work.Name));
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="name">Имя.</param>
    /// <param name="age">Возраст.</param>
    public Person(string name, int age, Company company)
    {
      this.Name = name;
      this.Age = age;
      this.Work = company;
    }

    #endregion
  }
}
