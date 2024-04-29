namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int number = Soucet(n);
            Console.WriteLine(number);
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
    }
}
