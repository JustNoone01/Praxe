using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxe
{
    internal class Kalkulacka
    {
        private void Fibonachi(int end)
        {
            int counter = 0;
            int counter2 = 1;
            int counter3;
            for (int cykly = 0; cykly <= end; cykly++)
            {
                Console.WriteLine(counter + counter2);
                counter3 = counter;
                counter = counter2;
                counter2 += counter3;
            }
        }
        private int Vypocet(int end)
        {
            int counter = 0;
            for (int i = 1; i <= end; i++)
            {
                counter = counter + i;
            }
            return counter;
        }
        public void Vypis()
        {
            bool success = false;
            int end = 0;
            while (!success)
            {
                Console.Write("Napiš konečné číslo: ");
                success = int.TryParse(Console.ReadLine(), out end);
            }
            Fibonachi(end);
            int soucet = Vypocet(end);
            Console.WriteLine($"Součet od 1 do {end}: {soucet}");
            Console.ReadKey(true);
        }
    }
}
