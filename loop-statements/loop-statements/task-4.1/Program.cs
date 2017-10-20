using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret.");
            int i = 1;

            do
            {
                Console.WriteLine($"{i}\t {Math.Round(Math.Sqrt(i), 2)}");
                i++;
            } while (i <= 10);
            Console.ReadKey();
        }
    }
}
