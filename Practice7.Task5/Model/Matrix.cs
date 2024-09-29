namespace Practice7.Task5.Model
{
  public class Matrix
  {
    private int[,] Data;

    public int this[int indexX, int indexY]
    {
      get => Data[indexX,indexY];
      set => Data[indexX, indexY] = value;
    }

    public Matrix(int[,] data)
    {
      this.Data = data;
    }
  }
}
