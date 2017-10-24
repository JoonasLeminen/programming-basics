using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin (13 kohdetta 1x2)");
            Random rnd = new Random();

            for (int i = 1; i <= 13; i++)
            {
                Console.Write($"Rivi {i}: ");
                Double k = rnd.NextDouble();
                if (k <= 0.4)
                {
                    Console.WriteLine("1");
                }
                else if (k <= 0.6)
                {
                    Console.WriteLine("x");
                }
                else
                {
                    Console.WriteLine("2");
                }
            }
            Console.ReadKey();
        }
    }
}
