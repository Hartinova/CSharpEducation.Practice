namespace Practice3.Task9
{
  /// <summary>
  /// Студент.
  /// </summary>
  public class Student
  {
    /// <summary>
    /// Имя.
    /// </summary>
    public string name;

    /// <summary>
    /// Возраст.
    /// </summary>
    public int age;

    public Student(string name, int age)
    {
      this.name = name;
      this.age = age;
    }

    /// <summary>
    /// Переименовать на Аноним.
    /// </summary>
    /// <param name="student">Студент.</param>
    public static void SetAnonymous(Student student)
    {
      student.name = "Аноним";
    }
  }
}
