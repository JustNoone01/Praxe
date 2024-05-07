namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zadani rozmeru
            Console.Write("Zadej počet řádků: ");
            int pocetradek;
            while (!(int.TryParse(Console.ReadLine(), out pocetradek) && pocetradek >= 2))
            {
                Console.WriteLine("Zadaná volba neodpovádí formátu.");
                Console.Write("Zadej počet řádků: ");
            }

            int pocetsloupcu;
            Console.Write("Zadej počet sloupců: ");
            while (!(int.TryParse(Console.ReadLine(), out pocetsloupcu) && pocetsloupcu >= 2))
            {
                Console.WriteLine("Zadaná volba neodpovídá formátu.");
                Console.Write("Zadej počet sloupců: ");
            }

            // vygenerovani nahodneho pole
            bool[,] pole = new bool[pocetradek, pocetsloupcu];
            Random random = new Random();
            for (int x = 0; x < pocetradek; x++)
            {
                for (int y = 0; y < pocetsloupcu; y++)
                {
                    pole[x, y] = random.Next(2) == 1; // nahodne cislo 0 nebo 1 == 1
                }
            }

            // hra
            while (true)
            {
                for (int x = 0; x < pocetradek; x++)
                {
                    for (int y = 0; y < pocetsloupcu; y++)
                    {
                        Console.Write((pole[x, y] ? "X" : "O") + " ");
                    }
                    Console.WriteLine();
                }

                if (CheckWin(pole))
                {
                    break;
                }

                Console.Write("Zadej řádek bodu který chceš změnit: ");
                int radek;
                while (!int.TryParse(Console.ReadLine(), out radek) || radek < 1 || radek > pocetradek)
                {
                    Console.WriteLine("Zadaná volba je příliš velká nebo malá.");
                    Console.Write("Zadej řádek bodu který chceš změnit: ");
                }

                int sloupec;
                Console.Write("Zadej sloupec bodu který chceš změnit: ");
                while (!int.TryParse(Console.ReadLine(), out sloupec) || sloupec < 1 || sloupec > pocetsloupcu)
                {
                    Console.WriteLine("Zadaná volba je příliš velká nebo malá.");
                    Console.Write($"Zadej výběr (): ");
                }

                // Meni pocatek souradnic z 1 na 0
                radek -= 1;
                sloupec -= 1;
                
                // Prebarvi policko a okolni pole
                pole[radek, sloupec] = !pole[radek, sloupec];
                if (radek + 1 < pocetradek)
                {
                    pole[radek + 1, sloupec] = !pole[radek + 1, sloupec];
                }
                if (radek - 1 >= 0)
                {
                    pole[radek - 1, sloupec] = !pole[radek - 1, sloupec];
                }
                if (sloupec + 1 < pocetsloupcu)
                {
                    pole[radek, sloupec + 1] = !pole[radek, sloupec + 1];
                }
                if (sloupec - 1 >= 0)
                {
                    pole[radek, sloupec - 1] = !pole[radek, sloupec - 1];
                }

                Console.Clear();
            }

            Console.WriteLine("Hra skončila!");
            Console.ReadLine();
        }

        // Zjisti, zda uzivatel vyhral - zda jsou vsechny symboly stejne
        private static bool CheckWin(bool[,] pole)
        {
            if (pole == null)                
                return true;

            int pocetRadek = pole.GetLength(0);
            int pocetSloupcu = pole.GetLength(1);
            bool firstVal = pole[0, 0];
            for (int i = 0; i < pocetRadek; i++)
            {
                for (int j = 0; j < pocetSloupcu; j++)
                {
                    if (pole[i, j] != firstVal)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
