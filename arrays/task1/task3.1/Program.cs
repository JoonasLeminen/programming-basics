using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukkoharjoitukset 3.1");
            Random rnd = new Random();
            int[] iT;
            iT = new int[10];
            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(0, 20);
                Console.WriteLine($"[{i}] = {iT[i]}");
            }
        }
        static int Numbers()
        {

        }
    }
}
