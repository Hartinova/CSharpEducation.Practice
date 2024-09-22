using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double katet1 = 3;
            double katet2 = 4;
            double gipotenuza = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
            Console.WriteLine($"Гипотенуза треугольника с катетами {katet1} и {katet2} равна {gipotenuza}.");
            Console.ReadLine();
        }
    }
}
