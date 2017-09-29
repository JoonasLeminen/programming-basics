using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define instruction
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla/parillisen tai parittoman.");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                // Define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // Program logic
                if (isNumber == true)
                {
                    if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
                    }
                    else if (evaluatedNumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on nolla");
                    }
                    if (evaluatedNumber % 2 == 1)
                    {
                        Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton.");
                    }
                    else if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen.");
                    }
                    if (evaluatedNumber % 2 == -1 )
                    {
                        Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton.");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeron");
                }
            } while (isNumber == true);
            Console.ReadKey();
        }
    }
}