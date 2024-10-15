using System;
using System.Collections.Generic;


namespace Practice8.Task3.Model
{
  /// <summary>
  /// Банковский счет.
  /// </summary>
  public class BankAccount
  {
    #region Поля и свойства

    /// <summary>
    /// Номер счета.
    /// </summary>
    public int Number { get; private set; }

    /// <summary>
    /// Владелец.
    /// </summary>
    public string Owner { get; private set; }

    /// <summary>
    /// Баланс.
    /// </summary>
    public decimal Balance { get; private set; }

    /// <summary>
    /// Осуществить транзакцию.
    /// </summary>
    /// <param name="amount">Средства.</param>
    /// <param name="typeTransaction">Тип транзакции.</param>
    public delegate void AccountTransactionDelegate(decimal amount, TypeTransaction typeTransaction);

    /// <summary>
    /// Осуществить транзакцию.
    /// </summary>
    public AccountTransactionDelegate moveMonew;

    #endregion

    #region Методы

    /// <summary>
    /// Внести деньги на счет. 
    /// </summary>
    /// <param name="amount">Сумма.</param>
    /// <exception cref="ArgumentException">Ошибка возникает, если пытаются внести отрицательную сумму</exception>
    private void Deposit(decimal amount)
    {
      if (amount < 0)
      {
        throw new ArgumentException($"Попытка зачисления отрицательной суммы {amount} на счет {this.Number} пользователя {this.Owner}.");
      }

      this.Balance += amount;
    }

    /// <summary>
    /// Снять деньги.
    /// </summary>
    /// <param name="amount">Сумма.</param>
    /// <exception cref="ArgumentException">Ошибка возникает, сели сумма снятия превышает баланс счета или сумма снятия отрицательная.</exception>
    /// <exception cref="WithdrawalLimitExceededException">Ошибка возникает, если месячный лимит снятия денежных средств со счета истрачен.</exception>
    private void Withdraw(decimal amount)
    {
      if (amount < 0)
      {
        throw new ArgumentException($"Попытка снятия отрицательной суммы {amount} со счета {this.Number} пользователя {this.Owner}.");
      }
      if (amount > this.Balance)
      {
        throw new ArgumentException($"Недостаточно средств на счете {this.Number} пользователя {this.Owner}. Баланс составляет {this.Balance}.");
      }

      this.Balance -= amount;
    }

    /// <summary>
    /// Осуществить транзакцию.
    /// </summary>
    /// <param name="amount">Средства.</param>
    /// <param name="typeTransaction">Тип транзакции.</param>
    public void RegistrateTransaction(decimal amount, TypeTransaction typeTransaction)
    {
      try
      {
        if (typeTransaction == TypeTransaction.Deposit)
        {
          this.Deposit(amount);
        }
        else
        {
          this.Withdraw(amount);
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

    /// <summary>
    /// Вывести информацию о транзакции.
    /// </summary>
    /// <param name="amount">Средства.</param>
    /// <param name="type">Тип транзакции.</param>
    public void PrintTransactionInfo(decimal amount, TypeTransaction type)
    {
      if (type == TypeTransaction.Deposit)
      {
        Console.WriteLine($"На счет пользователя {this.Owner} начислены средства в размере {amount} руб.");
      }
      else
      {
        Console.WriteLine($"Со счета пользователя {this.Owner} сняты средства в размере {amount} руб.");
      }
    }

    /// <summary>
    /// Вывести информацию о балансе.
    /// </summary>
    public void PrintBalanceInfo()
    {
      Console.WriteLine($"Текущее состояние счета пользователя {this.Owner} составляет: {this.Balance}.");
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="number">Номер счета.</param>
    /// <param name="owner">Владелец.</param>
    /// <param name="balance">Баланс.</param>
    public BankAccount(int number, string owner, decimal balance)
    {
      this.Number = number;
      this.Owner = owner;
      this.Balance = balance;
    }

    #endregion
  }
}

