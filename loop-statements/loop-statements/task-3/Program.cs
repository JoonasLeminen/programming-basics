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
            int oddSum = 0;
            int evenSum = 0;
            int k = 1;

            if (number < 0)
            {
                k = -1;
            }
                do
                {
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + i;
                    }
                    else
                    {
                        oddSum = oddSum + i;
                    }
                    i++;
                } while (i <= number*k);
            Console.WriteLine($"Parittomien summa: {oddSum*k}");
            Console.WriteLine($"Parillisten summa: {evenSum*k}");
            Console.ReadKey();
        }
    }
}
