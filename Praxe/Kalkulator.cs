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
        /* public void PascalTriangle(int n)
        {
            List<int> row = new List<int>() { 1 };

            for (int i = 0; i < n; i++)
            {
                List<int> newRow = new List<int>();

                foreach (int j in row)
                {
                    Console.Write(j);
                }

                for (int j = 0; j < row.Count - 1; j++)
                {
                    if (j == 0 || j == row.Count - 1)
                    {
                        newRow.Add(row[j] + 0);
                    }
                    newRow.Add(row[j] + row[j + 1]);
                }
                row = newRow;
            }
        } */

        public void PascalTriangle(int rows)
        {
            for (int i = 0; i <= rows; i++)
            {
                int n = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{n} ");
                    n = n * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }

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
