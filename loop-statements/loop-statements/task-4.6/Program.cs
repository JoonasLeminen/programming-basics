using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi nopanheittoa 1000 kertaa ja tulostaa kuutosen esiintymiskertojen lukumäärän.");
            Random rnd = new Random();
            int j = 0;

            for (int i = 0; i < 1000; i++)
            {
                int k = rnd.Next(1,7);
                if (k >= 6)
                    j++;
            }
            Console.WriteLine($"Heitit noppaa tuhat kertaa ja sait kutosen {j} kertaa.");
            Console.ReadKey();
        }
    }
}
