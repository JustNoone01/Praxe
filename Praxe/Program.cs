using System.Diagnostics;

namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soucet();
        }
        static int Soucet()
        {
            Console.WriteLine("Zadej poslední sčítané číslo: ");
            int cisloN =Convert.ToInt32(Console.ReadLine());

            int result = 0;
            for (int i = 0; i <= cisloN; i++)
            {
                 result +=i;
            }
            Console.WriteLine($"vaše číslo je: {result}");


            return result;  
        }
    }
}
