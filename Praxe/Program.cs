using System.Diagnostics;
using System.Reflection.Metadata;

namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej počet řádků: ");
            int Pocetradek;
            while (!int.TryParse(Console.ReadLine(), out Pocetradek))
            {
                Console.WriteLine("Zadaná volba neodpovádí formátu.");
                Console.Write("Zadej počet řádků: ");
            }

            int Pocetsloupcu;
            Console.Write("Zadej počet sloupců: ");
            while (!int.TryParse(Console.ReadLine(), out Pocetsloupcu))
            {
                Console.WriteLine("Zadaná volba neodpovádí formátu.");
                Console.Write("Zadej počet sloupců: ");
            }

            string[,] Pole = new string[Pocetradek, Pocetsloupcu];
            bool Game = true;

            Random random = new Random();
            for (int x = 0; x < Pocetradek; x++)
            {
                for (int y = 0; y < Pocetsloupcu; y++)
                {
                    int help = random.Next(0, 2);
                    if (help == 0)
                    {
                        Pole[x, y] = "O";
                    }
                    else
                    {
                        Pole[x, y] = "X";
                    }
                }
            }

            while (Game)
            {
                int idk = 1;
                for (int i = 0; i < Pocetradek; i++)
                {
                    for (int j = 0; j < Pocetsloupcu; j++)
                    {
                        if (Pole[i, j] == "X")
                        {
                            idk = 0;
                        }
                        else
                        {
                            idk = 1;
                            break;
                        }
                    }
                }
                if (idk == 0)
                {
                    Game = false;
                }

                for (int x = 0; x < Pocetradek; x++)
                {
                    for (int y = 0; y < Pocetsloupcu; y++)
                    {
                        Console.Write(Pole[x, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey(true);
                Console.WriteLine();

                Console.Write("Zadej řádek bodu který chceš změnit: ");
                int radek;
                while (!int.TryParse(Console.ReadLine(), out radek) || radek < 1 || radek > Pocetradek)
                {
                    Console.WriteLine("Zadaná volba je příliš velká nebo malá.");
                    Console.Write("Zadej řádek bodu který chceš změnit: ");
                }

                int sloupec;
                Console.Write("Zadej sloupec bodu který chceš změnit: ");
                while (!int.TryParse(Console.ReadLine(), out sloupec) || sloupec < 1 || sloupec > Pocetsloupcu)
                {
                    Console.WriteLine("Zadaná volba je příliš velká nebo malá.");
                    Console.Write($"Zadej výběr (): ");
                }

                radek -= 1;
                sloupec -= 1;
                
                if (Pole[radek, sloupec] == "X")
                {
                    Pole[radek, sloupec] = "O";
                }
                else
                {
                    Pole[radek, sloupec] = "X";
                }

                if (radek +1 > 4)
                {

                } // Dole
                else
                {
                    if (Pole[radek + 1, sloupec] == "X")
                    {
                        Pole[radek + 1, sloupec] = "O";
                    }
                    else
                    {
                        Pole[radek + 1, sloupec] = "X";
                    }
                }

                if (radek - 1 < 0) 
                {
                    
                } // Nahoře
                else
                {
                    if (Pole[radek - 1, sloupec] == "X")
                    {
                        Pole[radek - 1, sloupec] = "O";
                    }
                    else
                    {
                        Pole[radek - 1, sloupec] = "X";
                    }

                }

                if (sloupec + 1 > 4)
                {

                } // Vpravo
                else
                {
                    if (Pole[radek, sloupec + 1] == "X")
                    {
                        Pole[radek, sloupec + 1] = "O";

                    }
                    else
                    {
                        Pole[radek, sloupec + 1] = "X";
                    }
                }

                if (sloupec - 1 < 0)
                {
                } // Vlevo
                else
                {
                    if (Pole[radek, sloupec - 1] == "X")
                    {
                        Pole[radek, sloupec - 1] = "O";
                    }
                    else
                    {
                        Pole[radek, sloupec - 1] = "X";
                    }
                }

                Console.Clear();
            }
        }
    }
}
