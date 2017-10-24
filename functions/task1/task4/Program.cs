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
            Console.WriteLine("Funktiot - task4.");
            Console.WriteLine($"Suurin luku: " + numbers());
            Console.ReadKey();
        }
        static int numbers()
        {
            int num = 0;
            int max = 0;
            bool isNumber;
            Console.WriteLine("Syötä 10 positiivista lukua: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. luku: ");
                if (isNumber = int.TryParse(Console.ReadLine(), out num) && num > 0)
                {
                    if (max < num)
                    {
                        max = num;
                    }
                }
                else
                {
                    Console.WriteLine("Annoit väärän syötteen. Syötä positiivinen luku.");
                    i--;
                }
            }
            return max;
        }
    }
}
