using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukkoharjoitukset 3.2");
            Console.WriteLine("[X, Y] = Arvo");

            string[,] numbers = new string[10, 20];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    numbers[i, j] = getNum();
                    Console.WriteLine($"[{i}, {j}] = {numbers[i,j]}");
                }
            }
            Console.ReadKey();
        }
        static string getNum()
        {
            int n = rnd.Next(1, 100);
            string num = "";

            if (n < 10)
            {
                num = "0" + n.ToString();
            }
            else
            {
                num = n.ToString();
            }
            return num;
        }
    }
}
