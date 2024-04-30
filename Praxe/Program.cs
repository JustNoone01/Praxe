using System.Diagnostics;
using System.Reflection.Metadata;

namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Pole = new string[5, 5];
            bool Game = true;

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Pole[x, y] = "O";
                }
            }
            int som = 0;

            while (Game)
            {
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        Console.Write(Pole[x, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


                Console.Write("Zadej řádek bodu který chceš změnit: ");
                int radek;
                while (!int.TryParse(Console.ReadLine(), out radek) || radek < 1 || radek > 5)
                {
                    Console.WriteLine("Zadaná volba je příliš velká nebo malá.");
                    Console.Write($"Zadej výběr (): ");
                }

                int sloupec;
                Console.Write("Zadej sloupec bodu který chceš změnit: ");
                while (!int.TryParse(Console.ReadLine(), out sloupec) || sloupec < 1 || sloupec > 5)
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

                int idk = 1;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
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
                Console.Clear();
            }
        }
    }
}
