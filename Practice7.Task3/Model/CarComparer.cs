using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task3.Model
{
  public class CarComparer:IComparer<Car>
  {
    public int Compare(Car car1, Car car2)
    {
      if (car1==null || car2==null)
      {
        throw new ArgumentNullException("Некорректное значение.");
      }

      if (car1.Model != car2.Model)
      {
        return string.Compare(car1.Model, car2.Model);
      }

      return (car1.Make - car2.Make);
    }
  }
}
