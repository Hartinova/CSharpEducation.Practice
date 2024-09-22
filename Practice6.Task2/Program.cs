using Practice5.Task2;
using Practice6.Task1.Model;
using Practice6.Task2.Model;
using System;
using System.Data.SqlClient;

namespace Practice6.Task2
{
  public class Program
  {
    /// <summary>
    /// Логгер.
    /// </summary>
    public static ConsoleLogger logger = new ConsoleLogger();

    static void Main(string[] args)
    {
      var bankAccount = new BankAccount(BalanceType.Ordinary, 1111111111, "Oksana", 12334);
      bankAccount.Deposit(100);
      try
      {
        bankAccount.Deposit(-100);
      }
      catch(Exception ex)
      {
        logger.Error(ex.Message);
      }


      bankAccount.Withdraw(100);
      bankAccount.Withdraw(200);
      try
      {
        bankAccount.Withdraw(-100);
      }
      catch (Exception ex)
      {
        logger.Error(ex.Message);
      }
      try
      {
        bankAccount.Withdraw(200000);
      }
      catch (Exception ex)
      {
        logger.Error(ex.Message);
      }

      Console.WriteLine();

      var bankAccountTimur = new BankAccount(BalanceType.Cumulative, 22222222, "Timur", 12334);
      bankAccountTimur.Deposit(100);
      try
      {
        bankAccountTimur.Deposit(-100);
      }
      catch (Exception ex)
      {
        logger.Error(ex.Message);
      }

      try
      {
        bankAccountTimur.Withdraw(200000);
      }
      catch (Exception ex)
      {
        logger.Error(ex.Message);
      }
      bankAccountTimur.Withdraw(100);
      try
      {
        bankAccountTimur.Withdraw(-100);
      }
      catch (Exception ex)
      {
        logger.Error(ex.Message);
      }
      try
      {
        bankAccountTimur.Withdraw(200);
      }
      catch (Exception ex)
      {
        logger.Error(ex.Message);
      }

      Console.ReadLine();
    }
  }
}
