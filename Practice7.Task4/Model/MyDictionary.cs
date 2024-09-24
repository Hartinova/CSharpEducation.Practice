using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice7.Task4.Model
{
  public class MyDictionary : IEnumerator<string>
  {
    private Dictionary<string, int> Items;

    private int position = -1;

    public string Current
    {
      get
      {
        try
        {
          return Items.ElementAt(position).Key;
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    object IEnumerator.Current
    {
      get
      {
        return Current;
      }
    }

    public void Dispose()
    {
      Items = null;
    }

    public bool MoveNext()
    {
      position++;
      return (position < Items.Count);
    }

    public void Reset()
    {
      if (Items != null)
      {
        position = 0;
      }
      else
      {
        position = -1;
      }
    }

    public MyDictionary(List<string> list)
    {
      int i = 0;
      Items = new Dictionary<string, int>();
      foreach (var item in list)
      {
        Items.Add(item, i++);
      }
      if (Items != null) { position = 0; }
    }
  }
}
