using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna 2 lukua. Funktio palauttaa pienemmän.");
            Console.WriteLine("Anna ensimmäinen luku: ");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);
            Console.WriteLine("Anna toinen luku: ");
            string userInput2 = Console.ReadLine();
            int y = int.Parse(userInput2);

            int p = Calculator(x, y);
            if (p == x)
            {
                Console.WriteLine($"Luku {x} on pienempi kuin {y}");
            }
            else
            {
                Console.WriteLine($"Luku {y} on pienempi kuin {x}");
            }
            Console.ReadKey();
        }
        static int Calculator(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
