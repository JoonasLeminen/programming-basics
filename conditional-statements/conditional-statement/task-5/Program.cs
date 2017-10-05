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

            string firstName = "Uusi";
            string lastName = "Asiakas";
            Console.WriteLine("Anna nimesi: ");
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            Console.WriteLine("Nimi: " + firstName + " " + lastName);

            int discount = 0;
            int price = 16;
            bool discounted = false;
            
            Console.Write("Anna ikäsi: ");
            int age = int.Parse(Console.ReadLine());
            
            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && <= 15 && discounted = false);
            {
                discount = discount + 50;
                discounted = true;
            }
            
            else if (age >= 65 && discounted = false);
            {
                discount = discount + 50;
                discounted = true;
            }

        }
    }
}
