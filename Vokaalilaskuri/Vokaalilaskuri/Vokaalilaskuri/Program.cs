using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokaalilaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vokaalilaskuri - Vaihtoehto 3");
            Console.WriteLine("Kirjoita jotain: ");
            string userInput = Console.ReadLine();
            char[] array = new char[8] {'a', 'e', 'i', 'o', 'u', 'å', 'ä', 'ö' };
            int k = 0;

            foreach (Char x in userInput)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (x == array[i])
                    {
                        k++;
                    }
                }
            }
            Console.WriteLine($"Syötteesi sisältää vokaaleja {k} kappaletta.");
            Console.ReadKey();
        }
    }
}
