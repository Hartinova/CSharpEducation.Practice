using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double katet1 = 3;
            double gipotenuza = 5;

            double katet2 = Math.Sqrt(gipotenuza * gipotenuza - katet1 * katet1);

            Console.WriteLine($"У треугольника с катетом {katet1} и гипотенузой {gipotenuza} второй катет равен {katet2}.");
            Console.ReadLine();
        }
    }
}
