using Practice5.Task2;
using Practice6.Task3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task3
{
  internal class Program
  {
    /// <summary>
    /// Логгер.
    /// </summary>
    public static ConsoleLogger logger = new ConsoleLogger();

    static void Main(string[] args)
    {
      try
      {
        var user1 = new User("Камилла", 10);
        user1.IsAdult();
      }
      catch (Exception ex) 
      {
        logger.Error(ex.Message);
      }

      var user2 = new User("Timur", 30);
      user2.IsAdult();

      SetAge(user2);

      Console.ReadLine();
    }

    public static void SetAge(User user)
    {
      var exit = false;
      while (!exit)
      {
        Console.WriteLine($"Введите новый возраст для пользователя {user.Name}.");
        var newValue = Console.ReadLine();
        try
        {
          if (user.SetAge(newValue))
          {
            exit = true;
          }
          
        }
        catch(TooManyAttemptsException ex)
        {
          logger.Error(ex.Message);
          exit = true;
        }
        catch(Exception ex)
        {
          logger.Error(ex.Message);
        }
      }
    }
  }
}
