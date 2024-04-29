using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
                Fibonacci(cisloN);
               

                Console.ReadKey(true);
            }
        }
        public int Fibonacci(int cisloN)
        {
            int a = 0, b = 1;
            Console.Write($"{a} ");
            Console.Write($"{b} ");
            for (int i = 0;i < cisloN;i++)
            {
                int next = a + b;
                Console.Write($"{next} ");
                a = b;
                b = next;
            }
            return cisloN;
        }      
    }
}
