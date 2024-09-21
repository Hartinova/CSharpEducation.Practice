using System.Globalization;
using System;
using Practice6.Task1.Model;
using Practice5.Task2;

namespace Practice6.Task2.Model
{
  /// <summary>
  /// Банковский счет.
  /// </summary>
  public class BankAccount
  {
    #region Поля и свойства

    /// <summary>
    /// Логгер.
    /// </summary>
    public static ConsoleLogger logger = new ConsoleLogger();

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
    /// Тип счета.
    /// </summary>
    public BalanceType Type { get; private set; }

    /// <summary>
    /// Дата последнего снятия средств со счета.
    /// </summary>
    public DateTime LastWithdrawDate { get; private set; }

    #endregion

    #region Методы

    /// <summary>
    /// Внести деньги на счет. 
    /// </summary>
    /// <param name="amount">Сумма.</param>
    /// <exception cref="ArgumentException">Ошибка возникает, если пытаются внести отрицательную сумму</exception>
    public void Deposit(decimal amount)
    {
      if (amount < 0)
      {
        throw new ArgumentException($"Попытка зачисления отрицательной суммы {amount} на счет {this.Number} пользователя {this.Owner}.");
      }

      this.Balance += amount;
      logger.Info($"На счет {this.Number} пользователя {this.Owner} зачислены средства в размере {amount}.");
    }

    /// <summary>
    /// Снять деньги.
    /// </summary>
    /// <param name="amount">Сумма.</param>
    /// <exception cref="ArgumentException">Ошибка возникает, сели сумма снятия превышает баланс счета или сумма снятия отрицательная.</exception>
    /// <exception cref="WithdrawalLimitExceededException">Ошибка возникает, если месячный лимит снятия денежных средств со счета истрачен.</exception>
    public void Withdraw(decimal amount)
    {
      try
      {
        if (amount < 0)
        {
          throw new ArgumentException($"Попытка снятия отрицательной суммы {amount} со счета {this.Number} пользователя {this.Owner}.");
        }
        if (amount > this.Balance)
        {
          throw new ArgumentException($"Недостаточно средств на счете {this.Number} пользователя {this.Owner}. Баланс составляет {this.Balance}.");
        }
        if (this.Type == BalanceType.Cumulative && LastWithdrawDate != null && LastWithdrawDate.Year == DateTime.Now.Year && LastWithdrawDate.Month == DateTime.Now.Month)
        {
          throw new WithdrawalLimitExceededException($"Месячный лимит снятия денежных средств с накопительного счета {this.Number} пользователя {this.Owner} истрачен.");
        }

        this.Balance -= amount;
        this.LastWithdrawDate = DateTime.Now;
        logger.Info($"Со счета {this.Number} пользователя {this.Owner} сняты средства в размере {amount}.");
      } 
      catch (Exception)
      {
        throw;
      }
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="type">Тип счета.</param>
    /// <param name="number">Номер счета.</param>
    /// <param name="owner">Владелец.</param>
    /// <param name="balance">Баланс.</param>
    public BankAccount(BalanceType type, int number, string owner, decimal balance)
    {
      this.Type = type;
      this.Number = number;
      this.Owner = owner;
      this.Balance = balance;

      if (type == BalanceType.Ordinary)
      {
        logger.Info($"Создан счет {number}, принадлежащий {owner} с балансом = {balance}.");
      }
      else
      {
        logger.Info($"Создан накопительный счет {number}, принадлежащий {owner} с балансом = {balance}.");
      }
    }

    #endregion
  }
}
