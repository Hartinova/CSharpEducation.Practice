using Practice7.Task5.Model;
using System;

namespace Practice7.Task5
{
  public class Program
  {
    static void Main(string[] args)
    {
      int[,] array = { { 1, 2 }, { 2, 3 } };
      var matrix = new Matrix(array);

      matrix[0, 0] = 100;
    }
  }
}
