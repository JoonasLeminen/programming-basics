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
            Console.WriteLine("Kirjoita palindromi (Esim. saippuakivikauppias): ");
            string userInput = Console.ReadLine();
            string check = "";

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                check += userInput[i];
            }
            if (userInput == check)
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
