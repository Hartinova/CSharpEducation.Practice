using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        private const double pi = 3.14;
        
        static void Main(string[] args)
        {
            double r = 12.5;
            double area = pi * r * r;

            Console.WriteLine($"Площадь круга с радиусом {r} равна {area}.");
            Console.ReadLine();
        }

       
    }
}
