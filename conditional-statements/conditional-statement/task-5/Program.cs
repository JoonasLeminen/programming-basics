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

            float discount = 0;
            float price = 16;
            bool discounted = false;
            
            Console.Write("Anna ikäsi: ");
            int age = int.Parse(Console.ReadLine());
            
            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && age <= 15 && discounted == false)
            {
                discount = discount + 50;
                discounted = true;
            }
            else if (age >= 65 && discounted == false)
            {
                discount = discount + 50;
                discounted = true;
            }
            else if (age > 15 && age < 65)
            {
                Console.WriteLine("Oletko varusmies? Y/N");
                string conscriptResponse = Console.ReadLine().ToUpper();
                {
                    if (conscriptResponse == "Y")
                    {
                        discount = discount + 50;
                        discounted = true;
                    }
                    else
                    {
                        Console.WriteLine("Oletko Mtk:n jäsen? Y/N");
                        string mtkResponse = Console.ReadLine().ToUpper();
                        {
                            if (mtkResponse == "Y")
                            {
                                discount = discount + 15;
                                discounted = true;
                            }
                            else if (mtkResponse == "N")
                            {
                                discount = discount + 0;
                                discounted = false;
                            }
                        }
                        Console.WriteLine("Oletko opiskelija? Y/N");
                        string studentResponse = Console.ReadLine().ToUpper();
                        {
                            if (studentResponse == "Y")
                            {
                                discount = discount + 45;
                                discounted = true;
                            }
                            else if (studentResponse == "N")
                            {
                                discount = discount + 0;
                                discounted = false;
                            }
                        }
                    }
                }
            }
            float finalPrice = price - ((price * discount) / 100);
            Console.WriteLine($"Lippusi hinta on {finalPrice}e");
            Console.ReadKey();
        }
    }
}
