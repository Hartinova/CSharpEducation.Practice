namespace Practice8.Task5.Model
{
  public class Timer
  {
    public delegate void MethodContainer();

    public event MethodContainer Tick;
    public void Timer_Tick()
    {
      this.Tick();
    }

    public Timer() { }
  }
}
