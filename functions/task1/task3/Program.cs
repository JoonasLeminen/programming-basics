using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funktiot - task3.");
            int retNumber = numberFromRange(1, 10);
            Console.WriteLine($"Syöttämäsi luku {retNumber} on sallittu");
            Console.ReadKey();
        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            bool isNumber;
            int input = 0;
            int ret = 0;
            do
            {
                Console.WriteLine("Syötä luku väliltä 1-10: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);
                if (input >= lowerBound && input <= upperBound)
                {
                    ret = input;
                    break;
                }
                else
                {
                    isNumber = false;
                }
            } while (isNumber == false);
            return ret;
        }
    }
}
