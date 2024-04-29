using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxe
{
    internal class Kalkulator
    {
        private int Soucet(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        public void UI()
        {
            int n = GetInput();
            int result = Soucet(n);
            Console.WriteLine($"Vysledek: {result}");
        }

        private int GetInput()
        {
            int n;

            while (true)
            {
                Console.Write("Zadej n: ");
                bool ok = Int32.TryParse(Console.ReadLine(), out n);
                Console.Write("\n");

                if (ok)
                {
                    break;
                }
                Console.WriteLine("Chyba ve vstupu!");
            }

            return n;
        }
    }
}
