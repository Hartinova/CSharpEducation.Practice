using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// репозиторий игры Крестики-нолики
    /// </summary>
    public static class TicTacToe
    {
        /// <summary>
        /// массив данных, введенных игроками 1 и 2
        /// </summary>
        public static string[,] TicTacToeArray = CreateBeginTicTacToe();

        /// <summary>
        /// свойство окончания игры
        /// </summary>
        public static Queue QueueGame = Queue.First;


        /// <summary>
        /// создание начального массива данных
        /// </summary>
        /// <returns></returns>
        private static string[,] CreateBeginTicTacToe()
        {
            string[,] result = new string[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { result[i, j] = Const.CharNull; }
            }

            return result;
        }

       
        /// <summary>
        /// определить координаты и ввести значение
        /// </summary>
        /// <param name="inputStr"></param>
        /// <param name="mess"></param>
        /// <returns></returns>
        public static bool SetCoordinate(string inputStr, out string mess)
        {
            var result = false;
            mess = "Неверно заданы координаты.";

            var arr = inputStr.Split(',');

            if (arr.Count() != 2)
            {
                return false; 
            }

            if (int.TryParse(arr[0], out int i) && i > 0 && i <= 3)
            {
                if (int.TryParse(arr[1], out int j) && j > 0 && j <= 3)
                {
                    if (TicTacToeArray[i - 1, j - 1] == Const.CharNull)
                    {
                        TicTacToeArray[i - 1, j - 1] = (QueueGame == Queue.First) ? Const.CharGamer1 : Const.CharGamer2;
                       
                        mess = "";
                        result = true;
                    }
                    else
                    { mess = "В эту ячейку уже ввели данные. Выберите другую."; }
                }
            }
            return result;
        }

        /// <summary>
        /// смена хода
        /// </summary>
        public static void ChangeQueue()
        {  
            QueueGame = (QueueGame == Queue.First) ? Queue.Second : Queue.First;
        }

        /// <summary>
        /// проверка окончена ли игра
        /// </summary>
        /// <param name="mess">СООБЩЕНИЕ ДЛЯ ВЫВОДА ПОЛЬЗОВАТЕЛЮ    </param>
        /// <returns>TRUE-ЕСЛИ ИГРА ОКОНЧЕНА</returns>
        public static bool IsFinish(out string mess)
        {
            bool result = false;
            mess = string.Empty;

            if (IsWin(QueueGame))
            {
                mess = string.Format("Игра окончена победой {0} игрока.", (QueueGame == Queue.First) ? 1 : 2);
                return true;
            }

            if (!ExistNullValue())
            {
                mess = "Игра окончена. Ничья.";
                return true;
            }
            return result;
        }

        /// <summary>
        /// проверка на наличие пустых ячеек
        /// </summary>
        /// <param name="mess">сообщение для вывода пользователю</param>
        /// <returns>true-если есть пустые ячейки</returns>
        private static bool ExistNullValue()
        {
            bool result = false;

            for (int i = 0; i < TicTacToeArray.GetLength(0); i++)
            {
                for (int j = 0; j < TicTacToeArray.GetLength(1); j++)
                { 
                    if (TicTacToeArray[i, j] == Const.CharNull)
                    { return true; } 
                }
            }

            return result;
        }

        /// <summary>
        /// проверка на выигрыш
        /// </summary>
        /// <param name="queue">чья очередь</param>
        /// <returns>true - если текущий игрок выиграл</returns>
        private static bool IsWin(Queue queue)
        {
            bool result = false;
            string charGamer = (queue == Queue.First) ? Const.CharGamer1 : Const.CharGamer2;

            //поиск по строкам
            for (int i = 0; i < TicTacToeArray.GetLength(0); i++)
            {
                if (TicTacToeArray[i, 0] == charGamer && TicTacToeArray[i, 1] == charGamer && TicTacToeArray[i, 2] == charGamer)
                { return true; }
            }

            //поиск по колонкам
            for (int j = 0; j < TicTacToeArray.GetLength(1); j++)
            {
                if (TicTacToeArray[0, j] == charGamer && TicTacToeArray[1, j] == charGamer && TicTacToeArray[2, j] == charGamer)
                { return true; } 
            }

            // по диагонали
            if (TicTacToeArray[0, 0] == charGamer && TicTacToeArray[1, 1] == charGamer && TicTacToeArray[2, 2] == charGamer)
            { return true; }
            if (TicTacToeArray[0, 2] == charGamer && TicTacToeArray[1, 1] == charGamer && TicTacToeArray[2, 0] == charGamer)
            { return true; }

            return result;
        }
    }
}
