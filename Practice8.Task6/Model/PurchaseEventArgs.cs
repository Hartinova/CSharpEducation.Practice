using System;

namespace Practice8.Task6.Model
{
  public class PurchaseEventArgs: EventArgs
  {
    public string ProductName {  get; set; }

    public double Amount {  get; set; }

    public PurchaseEventArgs(string productName, double amount)
    {
      this.ProductName = productName;
      this.Amount = amount;
    }
  }
}
