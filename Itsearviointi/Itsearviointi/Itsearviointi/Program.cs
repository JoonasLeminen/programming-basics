using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Itsearvionti 1.1");
            Console.WriteLine("Kirjoita sana tai lause: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
            Console.ReadKey();
        }
    }
}
