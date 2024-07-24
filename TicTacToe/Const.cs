using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Const
    {
        public static string CharGamer1 = "X";
        public static string CharGamer2 = "O";
        public static string CharNull = " ";
    }

    /// <summary>
    /// Очередь хождения игроков
    /// </summary>
    public enum Queue
    {
        /// <summary>
        /// очередь 1го игрока
        /// </summary>
        First,
        /// <summary>
        /// очередь 2го игрока
        /// </summary>
        Second
    }

}
