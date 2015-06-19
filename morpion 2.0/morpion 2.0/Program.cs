using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morpion_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finDuProg = new bool();
            int joueur = 1;
            int n = 1;
            string pion = "X";
            int choix = 0;
            var table = new string[9];
            string message = "";

            table[0] = "1";
            table[1] = "2";
            table[2] = "3";
            table[3] = "4";
            table[4] = "5";
            table[5] = "6";
            table[6] = "7";
            table[7] = "8";
            table[8] = "9";
            DrawTab(table);

            do
            {
               
               Console.WriteLine("\n joueur {0} entrez le numéro de la case", joueur);
                if (Int32.TryParse(Console.ReadLine(), out choix))
                {
                    message = test(table, choix);

                    if (String.IsNullOrEmpty(message))
                    {
                        table = placerUnPion(choix, pion, table);

                        DrawTab(table);
                    }
                    else
                    {
                        DrawTab(table);
                        Console.WriteLine(message);
                        continue;
                    }
                }

                else
                {
                    DrawTab(table);
                    Console.WriteLine("ce n'est pas un chiffre");
                    continue;
                }
                bool result = vic(pion, table);

                if (result == true)
                {
                    Console.WriteLine("j{0} a gagné", joueur);
                    finDuProg = true;
                }

                if (joueur == 1)
                {
                    joueur = 2;
                    pion = "O";
                    n++;
                }
            
                else
                {
                    joueur = 1;
                    pion = "X";
                    n++;
                }
            }
            while (n <= 9 && finDuProg == false);

            Console.WriteLine("partie nul, merci d'avoir joué");
        }

        static void DrawTab(string[] pions)
        {
            Console.Clear();
            Console.WriteLine("\n-------------");
            Console.WriteLine("|" + " " + pions[0] + " " + "|" + " " + pions[1] + " " + "|" + " " + pions[2] + " " + "|");
            Console.WriteLine("-------------");
            Console.WriteLine("|" + " " + pions[3] + " " + "|" + " " + pions[4] + " " + "|" + " " + pions[5] + " " + "|");
            Console.WriteLine("-------------");
            Console.WriteLine("|" + " " + pions[6] + " " + "|" + " " + pions[7] + " " + "|" + " " + pions[8] + " " + "|");
            Console.WriteLine("-------------");
        }

        static string[] placerUnPion(int choix, string typePion, string[] pions)
        {
            pions[choix - 1] = typePion;
            return pions;
        }

        static string test(string[] pions, int choix)
        {

            if (choix <= 9 && choix >= 1)
            {
                if (pions[choix - 1] != "X" && pions[choix - 1] != "O")
                {
                    return "";
                }
                else
                {
                    return "cette case est deja joué";
                }
            }
            else
            {
                return "ce numero n'est pas valide";
            }
        }

        static bool vic(string pion, string[] pions)
        {
            if (pions[0] == pion && pions[1] == pion && pions[2] == pion)
            {
                return true;
            }

            else if (pions[3] == pion && pions[4] == pion && pions[5] == pion)
            {
                return true;
            }

            else if (pions[6] == pion && pions[7] == pion && pions[8] == pion)
            {
                return true;
            }

            else if (pions[0] == pion && pions[3] == pion && pions[6] == pion)
            {
                return true;
            }

            else if (pions[1] == pion && pions[4] == pion && pions[7] == pion)
            {
                return true;
            }

            else if (pions[2] == pion && pions[5] == pion && pions[8] == pion)
            {
                return true;
            }

            else if (pions[0] == pion && pions[4] == pion && pions[8] == pion)
            {
                return true;
            }

            else if (pions[2] == pion && pions[4] == pion && pions[6] == pion)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

