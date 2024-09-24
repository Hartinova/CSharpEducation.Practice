using System.Collections;
using System.Collections.Generic;

namespace Practice7.Task4.Model
{
  /// <summary>
  /// Список.
  /// </summary>
  public class MyList:IEnumerable<int>
  {
    #region Поля и свойства

    private List<int> Items;

    #endregion

    #region Методы
        
    public IEnumerator<int> GetEnumerator()
    {
      foreach (var item in Items)
      {
        yield return item;
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    #endregion

    #region Конструкторы

    public MyList( List<int> items) 
    {
      this.Items = items;
    }


    #endregion

  }
}
