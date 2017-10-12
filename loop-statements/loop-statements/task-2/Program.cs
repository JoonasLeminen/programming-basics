using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 1;
            int f = 0;
            do
            {
                i = i + 1;
                f = i * 1;
            } while (i < number);
            Console.Write($"Syötit: {number}, Summa: {f}");
            Console.ReadLine();
        }
    }
}
