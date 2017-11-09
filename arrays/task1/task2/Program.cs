using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 7 eri lukua 1-40 ja tulostaa arvotut luvut pienimmästä suurimpaan.");
            Random rnd = new Random();
            int[] iT;
            iT = new int[7];

            for (int i = 0; i < 7; i++)
            {
                iT[i] = rnd.Next(1,39);
                iT[i] = iT[1];
            }
            for (int i = 0; i < iT.Length; i++)
            {
                Console.WriteLine($"{iT[1]}");
            }

            Console.ReadKey();
        }
    }
}
