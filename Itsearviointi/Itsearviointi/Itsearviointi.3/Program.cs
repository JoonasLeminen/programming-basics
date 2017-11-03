using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointi._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Syötettyjen lukujen summa: " + numbers());
            Console.ReadKey();
        }
        static int numbers()
        {
            Console.WriteLine("Itsearviointi 1.3");
            Console.WriteLine("Syötä luku: ");
            int sum = 0;
            
            while (true)
            {
                string userInput = Console.ReadLine();
                int num = int.Parse(userInput);
                if (num != -1)
                {
                    sum = num + sum;
                }
                else
                {
                    sum = num + sum;
                    break;
                }
            }
            return sum;
        }
    }
}
