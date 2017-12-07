using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijonoharjoitukset4");
            Console.WriteLine("Kirjoita jotain: ");
            string userInput = Console.ReadLine();
            userInput.ToUpper();
            string mirror;

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.Write(userInput[userInput.Length - i - 1]);
            }
            if (mirror == userInput)
            {
                Console.WriteLine($"Sana {userInput} on palintromi");
            }
            else
            {
                Console.WriteLine($"Sana {userInput} ei ole palintromi");
            }
            Console.ReadKey();
        }
    }
}
