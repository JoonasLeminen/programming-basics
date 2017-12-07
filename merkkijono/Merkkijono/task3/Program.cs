using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijonoharjoitukset3");
            Console.WriteLine("Kirjoita jotain: ");
            string userInput = Console.ReadLine();
            int k = 0;

            foreach (Char x in userInput)
            {
                if (x == 'l')
                    k++;
            }

            Console.WriteLine($"Syötteessä {userInput} on {k} L kirjainta.");
            Console.ReadKey();
        }
    }
}
