using System.Diagnostics;
using System.Diagnostics.Contracts;
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
                    Pole[x, y] = "O";
                }
            }
            
            for (int i  = 0; i < Pole.Length; i++)
            {
                for (int j = 0; j < Pole.Length; j++)
                {
                    int radnx = random.Next(0, Pocetradek);
                    int randy = random.Next(0, Pocetsloupcu);

                    if (Pole[radnx, randy] == "X")
                    {
                        Pole[radnx, randy] = "O";
                    }
                    else
                    {
                        Pole[radnx, randy] = "X";
                    }

                    if (radnx + 1 > Pocetradek - 1)
                    {

                    } // Dole
                    else
                    {
                        if (Pole[    + 1, randy] == "X")
                        {
                            Pole[radnx + 1, randy] = "O";
                        }
                        else
                        {
                            Pole[radnx + 1, randy] = "X";
                        }
                    }

                    if (radnx - 1 < 0)
                    {

                    } // Nahoře
                    else
                    {
                        if (Pole[radnx - 1, randy] == "X")
                        {
                            Pole[radnx - 1, randy] = "O";
                        }
                        else
                        {
                            Pole[radnx - 1, randy] = "X";
                        }

                    }

                    if (randy + 1 > Pocetsloupcu - 1)
                    {

                    } // Vpravo
                    else
                    {
                        if (Pole[radnx, randy + 1] == "X")
                        {
                            Pole[radnx, randy + 1] = "O";

                        }
                        else
                        {
                            Pole[radnx, randy + 1] = "X";
                        }
                    }

                    if (randy - 1 < 0)
                    {
                    } // Vlevo
                    else
                    {
                        if (Pole[radnx, randy - 1] == "X")
                        {
                            Pole[radnx, randy - 1] = "O";
                        }
                        else
                        {
                            Pole[radnx, randy - 1] = "X";
                        }
                    }
                }
            }

            while (Game)
            {
                for (int x = 0; x < Pocetradek; x++)
                {
                    for (int y = 0; y < Pocetsloupcu; y++)
                    {
                        Console.Write(Pole[x, y] + " ");
                    }
                    Console.WriteLine();
                }

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
                            goto fail;
                        }
                    }
                }
                for (int i = 0; i < Pocetradek; i++)
                {
                    for (int j = 0; j < Pocetsloupcu; j++)
                    {
                        if (Pole[i, j] == "O")
                        {
                            idk = 0;
                        }
                        else
                        {
                            idk = 1;
                            goto fail;
                        }
                    }
                }
                fail:
                if (idk == 0)
                {
                    Game = false;
                }


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

                if (radek +1 > Pocetradek-1)
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

                if (sloupec + 1 > Pocetsloupcu-1)
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
