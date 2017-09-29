using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = 0;
            int price = 16;
            bool discounted = false;

            
            Console.Write("Ikä: ?");
            int age = int.Parse(Console.ReadLine());
            
            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if {age >= 7 && <= 15 && discounted = false}
            {
                discount = discount + 50;
                discounted = true;
            }
            else if (age >= 65 && discounted = false)
            {
                discount = discount + 50;
                discounted = true;
            }
        }
    }
}
