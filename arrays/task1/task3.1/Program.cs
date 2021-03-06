﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukkoharjoitukset 3.1");
            Console.WriteLine("[X] = Arvo");

            string[] numbers = new string[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = getNum();
                Console.WriteLine($"[{i}] = {numbers[i]}");
            }
            Console.ReadKey();
        }
        static string getNum()
        {
            int n = rnd.Next(1, 21);
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
