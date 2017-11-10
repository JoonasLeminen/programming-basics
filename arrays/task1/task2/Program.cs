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
            iT = new int[9];

            for (int i = 0; i < 8; i++)
            {
                iT[i] = rnd.Next(1, 40);

                for (int j = 0; j < i; j++)
                {
                    if (iT[i] == iT[j])
                    {
                        i--;
                    }
                }
            }

            Array.Sort(iT, null, 0,7);
            Console.WriteLine("Loton oikea rivi on:");
            for (int i = 0; i < iT.Length - 2; i++)
            {
                Console.Write($"{iT[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Lisänumero: {iT[7]}");
            Console.WriteLine($"Tuplausnumero: {rnd.Next(1, 40)}");
            Console.ReadKey();
        }
    }
}
