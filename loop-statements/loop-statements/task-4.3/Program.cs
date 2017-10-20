using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä [0-50].");
            Random rnd = new Random();

            for (int i = 1; i <= 4; i++) 
            {
                for (int k = 1; k <= 5; k++)
                {
                    if (k < 5)
                    {
                        Console.Write($"{rnd.Next(50)}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{rnd.Next(50)}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
