using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morpion_2._0
{
    class Program
    { 
        

            int n = 0;
        static void Main(string[] args)
        {

           string x = "X";
            string o = "O";
            bool j2NoWin = new bool();
            bool j1NoWin = new bool();

            var table = new string[9];
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
                n++;
                Console.WriteLine("\n joueur 1 entrez le numéro de la case");
                int choix = int.Parse(Console.ReadLine());

                table = jouer(choix, x, table);

                DrawTab(table);

                vic();


                n++;
                Console.WriteLine("\n joueur 2 entrez le numéro de la case ");
                choix = int.Parse(Console.ReadLine());

                table = jouer(choix, o, table);

                DrawTab(table);

                vic(o);
            }
            while (n < 9);
        }
        

        static void DrawTab(string[] pions)
        {
            Console.WriteLine("\n-------");
            Console.WriteLine("|" + pions[0] + "|" + pions[1] + "|" + pions[2] + "|");
            Console.WriteLine("-------");
            Console.WriteLine("|" + pions[3] + "|" + pions[4] + "|" + pions[5] + "|");
            Console.WriteLine("-------");
            Console.WriteLine("|" + pions[6] + "|" + pions[7] + "|" + pions[8] + "|");
            Console.WriteLine("-------");
        }

        static string[] jouer(int choix, string typePion, string[] pions)
        {
            pions[choix - 1] = typePion;
            return pions;
        }

        static string vic(string x, string[] table, string[] pions)
        {
            if (table[0] == o && table[1] == o && table[2] == o)
            {
                Console.WriteLine("j2 a gagné");
            }

            else if (table[3] == o && table[4] == o && table[5] == o)
            {
                Console.WriteLine("j2 a gagné");
            }

            else if (table[6] == o && table[7] == o && table[8] == o)
            {
                Console.WriteLine("\n j2 a gagné");
            }

            else if (table[0] == o && table[3] == o && table[6] == o)
            {
                Console.WriteLine("\n j2 a gagné");
            }

            else if (table[1] == o && table[4] == o && table[7] == o)
            {
                Console.WriteLine("\n j2 a gagné");
            }

            else if (table[2] == o && table[5] == o && table[8] == o)
            {
                Console.WriteLine("\n j2 a gagné");
            }

            else if (table[0] == o && table[4] == o && table[8] == o)
            {
                Console.WriteLine("\n j2 a gagné");
            }

            else if (table[2] == o && table[4] == o && table[6] == o)
            {
                Console.WriteLine("\n j2 a gagné");
            }
            else
            {
                j2NoWin = true;
            }
        }
        }
    }

