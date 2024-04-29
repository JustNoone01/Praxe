﻿using System.Diagnostics;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka K1 = new Kalkulacka();
            K1.vypis();
        }
        static public int Kalkulator(int end)
        {
            int counter = 0;
            for (int i = 1; i <= end; i++)
            {
                counter = counter + i;
            }
            return counter;
        }
        static public void vypsat()
        {
            bool success = false;
            int end = 0;
            while (!success)
            {
                Console.Write("Napiš konečné číslo: ");
                success = int.TryParse(Console.ReadLine(), out end);
            }

            int soucet = Kalkulator(end);
            Console.WriteLine($"Součet od 1 do {end}: {soucet}");
            Console.ReadKey(true);
        }
    }
}
