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
            List<int> prevNumbers = new List<int>() { 0, 1 };
            int counter = 0;

            Console.Write($"{prevNumbers[0]} ");

            while (counter < n)
            {
                int sum = prevNumbers[0] + prevNumbers[1];
                result += sum;
                prevNumbers[0] = prevNumbers[1];
                prevNumbers[1] = sum;
                counter++;
                Console.Write($"{prevNumbers[1]} ");
            }

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
