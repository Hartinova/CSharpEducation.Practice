using Practice8.Task3.Model;
using System;

namespace Practice8.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var bankAccount = new BankAccount(1, "Oksana", 12345);
      bankAccount.PrintBalanceInfo();
      bankAccount.moveMonew += bankAccount.RegistrateTransaction;
      bankAccount.moveMonew += bankAccount.PrintTransactionInfo;

      bankAccount.moveMonew(1000, TypeTransaction.Deposit);
      bankAccount.PrintBalanceInfo();

      bankAccount.moveMonew(700, TypeTransaction.Withdraw);
      bankAccount.PrintBalanceInfo();

      Console.ReadLine();
    }  
  }
}
