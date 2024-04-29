using System.Diagnostics;

namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //cau
            Console.WriteLine("Karel");
            //comment
            Console.Write("je");
            Console.ReadKey();
            //comment2
            //comment3

            Console.WriteLine("Napiš konečné číslo: ");
            int konec = int.Parse(Console.ReadLine());
            Kalkulator(konec);
            Console.ReadKey(true);
        }
        static void Kalkulator(int end)
        {
            int start = 1;

            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                counter = counter + i;
            }
            Console.WriteLine(counter);
        }
    }
}
