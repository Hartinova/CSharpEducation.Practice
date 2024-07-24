using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var input = string.Empty;
            var flagFinish = false;
          
            Console.WriteLine("Начата игра Крестики-нолики.");
            PrintArray(TicTacToe.TicTacToeArray);

            do
            {
                Console.WriteLine(string.Format("Игрок {0}, введите строку и столбец (от 1 до 3) через запятую:",
                    (TicTacToe.QueueGame == Queue.First) ? 1 : 2));
                var inputString = Console.ReadLine().Trim().ToLower();
                if(TicTacToe.SetCoordinate(inputString, out string mess))
                {
                    if (TicTacToe.IsFinish(out string mes))
                    {
                        Console.WriteLine(mes);
                        flagFinish = true;
                    }
                    else
                    { TicTacToe.ChangeQueue(); }
                }
                else
                {
                    Console.WriteLine(mess);
                }
                PrintArray(TicTacToe.TicTacToeArray);
                
            }
            while (!flagFinish);

            Console.ReadLine();
        }

        /// <summary>
        /// вывести данные массива
        /// </summary>
        /// <param name="array"></param>
        private static void PrintArray( string[,] array)
        {
            Console.WriteLine("-------");
            for ( int i = 0;i< array.GetLength(0);i++)
            {
                string s = "|";
                for( int j = 0;j< array.GetLength(1);j++)
                { s += array[i, j] + "|"; }
                Console.WriteLine(s);
            }
            Console.WriteLine("-------");
        }

      
    }
}
