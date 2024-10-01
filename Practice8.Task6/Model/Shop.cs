using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task6.Model
{
  public class Shop
  {
    public double Amount {  get; private set; }

    public delegate void ProductHandler(Product sender, PurchaseEventArgs args);

    public event ProductHandler PurchaseCompleted;

    public void Purchase(Product product, int count)
    {
      var amount= count * product.Price;
      this.Amount += amount;
      this.PurchaseCompleted?.Invoke(product, new PurchaseEventArgs(product.Name, amount));
    }

    public Shop() 
    {
      this.Amount = 0;
    }
  }
}
