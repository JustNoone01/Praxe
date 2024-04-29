using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxe
{
    internal class Kalkulator
    {
        private int Soucet(int cisloN)
        {
            int result = 0;
            for (int i = 0; i <= cisloN; i++)
            {
                result += i;
            }
            return result;
        }
        public void Uzivatel()
        {
            Console.WriteLine("Zadej poslední sčítané číslo: ");
            //int cisloN;
            bool ok = Int32.TryParse(Console.ReadLine(), out int cisloN);
            if (!ok)
            {
                Console.WriteLine("Neplatný vstup");
                Uzivatel();
            }
            else
            {
                int number = Soucet(cisloN);
                Console.WriteLine($"vaše číslo je: {number}");

                Console.ReadKey(true);
            }
        }
    }
}
