using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee ohjelma, joka arpoo 100 lukua [0...50] väliltä ja tallettaa ne taulukkoon iT. Arvotut luvut sekä luvuista saatu keskiarvo, joka ilmoitetaan käyttäjälle.");
            Random rnd = new Random();
            int[] iT;
            iT = new int[100];
            double sum = 0;

            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(0, 50);
                Console.WriteLine($"{iT[i]}");
            }

            for (int i = 0; i < iT.Length; i++)
            {
                sum += iT[i];
            }
            double ka = sum / 100;
            Console.WriteLine($"Keskiarvo: {ka}");
            Console.ReadKey();
        }
    }
}
