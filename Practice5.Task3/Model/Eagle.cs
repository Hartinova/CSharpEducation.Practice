using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3.Model
{
  /// <summary>
  /// Орел.
  /// </summary>
  public class Eagle: IFlyable
  {
    public void Fly()
    {
      Console.WriteLine("Eagle is soaring high");
    }
    public Eagle() { }
  }
}
