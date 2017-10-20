using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako kertaa haluat heittää kolikkoa?");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 1;
            int kruuna = 0;
            int klaava = 0;
            Random rnd = new Random();

            do
            {
                if (rnd.Next(2) == 1)
                    kruuna = kruuna + 1;
                else
                    klaava = klaava + 1;
                i++;
            } while (i <= number);

            Console.WriteLine($"Heitit {number} kertaa. Sait {klaava} kertaa klaavan ja {kruuna} kertaa kruunan.");
            Console.ReadKey();
        }
    }
}
