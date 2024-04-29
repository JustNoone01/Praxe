namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UI();

            Console.ReadLine();
        }

        static int Soucet(int n) 
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        static void UI()
        {
            int n = getInput();
            int result = Soucet(n);
            Console.WriteLine($"Vysledek: {result}");
        }

        static int getInput()
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
