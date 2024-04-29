using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxe
{
    internal class Kalkulator
    {
        public int Fibonacci(int n)
        {
            int result = 0;
            int prevNumber1 = 0;
            int prevNumber2 = 1;
            int counter = 0;

            Console.Write($"{prevNumber1} ");

            while (counter < n - 2)
            {
                Console.Write($"{prevNumber2} ");
                int sum = prevNumber1 + prevNumber2;
                result += sum;
                prevNumber1 = prevNumber2;
                prevNumber2 = sum;
                counter++;
            }

            Console.Write($"{prevNumber2} ");


            return result;
        }

        private int Soucet(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        public void UISoucet()
        {
            int n = GetInput();
            int result = Soucet(n);
            Console.WriteLine($"Vysledek: {result}");
        }

        public void UIFibonacci()
        {
            int n = GetInput();
            int result = Fibonacci(n);
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
