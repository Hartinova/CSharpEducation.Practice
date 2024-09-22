namespace Practice3.Task9
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student("Тимур", 18);
      Student.SetAnonymous(student);
    }
  }
}
