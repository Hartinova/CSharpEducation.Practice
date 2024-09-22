using Practice5.Task2;
using Practice6.Task4.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task4
{
  public class Program
  {
    public static ConsoleLogger logger = new ConsoleLogger();

    static void Main(string[] args)
    {
      var grades = new GradesLesson("English", "Kamilla");
      GetGradesFromFile(grades);
      /* try
       {
         grades.GetGradesFromFile("20.txt");
       }
       catch(Exception ex)
       {
         logger.Error(ex.Message);
       }

       try
       {
         grades.GetGradesFromFile("1.txt");
       }
       catch (Exception ex)
       {
         logger.Error(ex.Message);
       }

       try
       {
         grades.GetGradesFromFile("2.txt");
       }
       catch (Exception ex)
       {
         logger.Error(ex.Message);
       }

       try
       {
         grades.GetGradesFromFile("3.txt");
       }
       catch (Exception ex)
       {
         logger.Error(ex.Message);
       }
      */
      Console.ReadLine();
    }

    public static void GetGradesFromFile(GradesLesson gradesLesson)
    {
      var exit = false;
      while (!exit)
      {
        Console.WriteLine("Введите путь к файлу. Для выхода введите 'exit'.");
        var path = Console.ReadLine();
        if (path == "exit")
        {
          return;
        }
        try
        {
          if (gradesLesson.GetGradesFromFile(path))
          {
            exit = true;
          }
        }
        catch (FileNotFoundException ex)
        {
          logger.Error(ex.Message);
        }
        catch (IOException ex)
        {
          logger.Error(ex.Message);
          logger.Info("Файл занят другим приложением. Освободите файл и попробуйте задать его снова.");
        }
        catch (Exception ex)
        {
          logger.Error(ex.Message);
        }
      }
    }
  }
}
