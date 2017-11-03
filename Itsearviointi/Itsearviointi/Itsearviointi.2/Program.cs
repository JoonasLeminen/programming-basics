using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointi._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Itsearviointi 1.2");
            Console.WriteLine("Kirjoita sana tai lause: ");
            string userInput = Console.ReadLine();
            
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
            Console.ReadKey();
        }
    }
}
