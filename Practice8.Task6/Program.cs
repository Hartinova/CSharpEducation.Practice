using Practice8.Task6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task6
{
  public class Program
  {
    static void Main(string[] args)
    {
      var shop=new Shop();
      shop.PurchaseCompleted += PrintPurchase;

      shop.Purchase(new Product("юбка", 1000), 5);

      Console.ReadLine();
    }

    private static void PrintPurchase(Product product, PurchaseEventArgs args)
    {
      Console.WriteLine($"Приобретен товар '{args.ProductName}' на сумму {args.Amount}.");
    }
  }
}
