using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст первой фразы:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите текст второй фразы:");
            string str2 = Console.ReadLine();
            Console.WriteLine($"{str1} {str2}");
            Console.ReadLine();
        }
    }
}
