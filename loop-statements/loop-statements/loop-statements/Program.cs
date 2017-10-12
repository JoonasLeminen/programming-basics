using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 0;
            int f = 1;

            if (number < 1)
            {
                Console.WriteLine("Vastaus: Määrittelemätön.");
            }
            else
            {
                do
                {
                    i = i + 1;
                    f = f * i;
                } while (i < number);

                Console.WriteLine($"\tSyötit: {number}\n\tVastaus: {f}");
            }
            Console.ReadKey();
        }
    }
}
