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
            int cisloN = Convert.ToInt32(Console.ReadLine());
            int number = Soucet(cisloN);
            Console.WriteLine($"vaše číslo je: {number}");
        }

        
    }
}
