using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijonoharjoitukset2");
            Console.WriteLine("Kirjoita jotain: ");
            string userInput = Console.ReadLine();
            userInput = userInput.Replace("e", "@");
            Console.WriteLine($"{userInput}");
            Console.ReadKey();
        }
    }
}
