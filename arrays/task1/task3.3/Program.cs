using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukkoharjoitukset3.3");
            Console.WriteLine();
            Console.Write("        ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"0{i + 1} ");
            }
            Console.WriteLine("10");
            Console.WriteLine("        -----------------------------");
            Random rnd = new Random();
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(10,100);
            }
            for (int i = 0; i < 10; i++)
            {
                arrT_2[i] = rnd.Next(10,100);
            }
            for (int i = 0; i < 10; i++)
            {
                if (arrT_1[i] >= arrT_2[i])
                {
                    arrT_3[i] = arrT_1[i];
                }
                else
                {
                    arrT_3[i] = arrT_2[i];
                }
            }

            Console.Write("arrT_1: ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{arrT_1[i]} ");
            }
            Console.WriteLine($"{arrT_1[9]}");

            Console.Write("arrT_2: ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{arrT_2[i]} ");
            }
            Console.WriteLine($"{arrT_2[9]}");

            Console.Write("arrT_3: ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{arrT_3[i]} ");
            }
            Console.WriteLine($"{arrT_3[9]}");
            Console.ReadKey();
        }
    }
}
