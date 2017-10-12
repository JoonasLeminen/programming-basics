using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäisen parittoman ja parillisen luvun summan N:stä.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 1;
            int pariton = 1;
            int parillinen = 1;

            if (number < 1)
            {
                Console.WriteLine("Vastaus: Määrittelemätön.");
            }
            else
            {
                do
                {
                    pariton = 0;
                    parillinen = 0;
                    i = i + 1;
                } while (number < i);
                Console.WriteLine($"Parittomien summa: {pariton}");
                Console.WriteLine($"Parillisten summa: {parillinen}");
            }
            Console.ReadKey();
        }
    }
}
