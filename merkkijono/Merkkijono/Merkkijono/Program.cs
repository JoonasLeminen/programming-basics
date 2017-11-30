using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijonoharjoitukset1");
            Console.WriteLine("Kirjoita jotain: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Kirjoitit {userInput.Length} merkkiä.");

            Console.ReadKey();
        }
    }
}
