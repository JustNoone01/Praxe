using System.Diagnostics;

namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uzivatel();
        }
        static int Soucet(int cisloN)
        {
            int result = 0;
            for (int i = 0; i <= cisloN; i++)
            {
                 result +=i;
            }
            return result;  
        }
        static void Uzivatel()
        {
            Console.WriteLine("Zadej poslední sčítané číslo: ");
            int cisloN;
            bool ok = Int32.TryParse(Console.ReadLine(), out cisloN);
            if (!ok)
            {
                Console.WriteLine("Neplatný vstup");
                Uzivatel();
            }
            int number = Soucet(cisloN);
            Console.WriteLine($"vaše číslo je: {number}");

            Console.ReadKey(true);
        }

        
    }
}
