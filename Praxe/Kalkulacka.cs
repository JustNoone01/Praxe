using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxe
{
    internal class Kalkulacka
    {
        private int start = 1;

        private int vypocet(int end)
        {
            int counter = 0;
            for (int i = 1; i <= end; i++)
            {
                counter = counter + i;
            }
            return counter;
        }
        public void vypis()
        {
            bool success = false;
            int end = 0;
            while (!success)
            {
                Console.Write("Napiš konečné číslo: ");
                success = int.TryParse(Console.ReadLine(), out end);
            }

            int soucet = vypocet(end);
            Console.WriteLine($"Součet od 1 do {end}: {soucet}");
            Console.ReadKey(true);
        }
    }
}
