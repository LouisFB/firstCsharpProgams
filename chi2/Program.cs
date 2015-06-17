using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chi2
{
    class Program
    {
        static void Main(string[] args)
        {
                Random rdm = new Random();
                int n1 = rdm.Next(1, 100);
                int ne = 0;
                int essai = 0;
                string enter;
                do
                {
                    Console.WriteLine("entre un nombre");
                    enter = Console.ReadLine();


                    if (Int32.TryParse(enter, out essai))
                    {

                        ne++;

                        if (essai > n1)
                        {
                            Console.WriteLine("le chiffre est plus petit");

                        }
                        else if (essai < n1)
                        {
                            Console.WriteLine("le chiffre est plus grand");
                        }
                    }
                    else if (enter != "echap") 
                    {
                        Console.WriteLine("ce n'est pas un chiffre");
                    }

                }
                while (essai != n1 && enter != "echap");
                if (ne == 1 && enter != "echap")
                {
                    Console.WriteLine("Bravo!!!  tu as utilisé " + ne + " essai");
                }
                else if (ne > 1 && enter != "echap")
                {
                    Console.WriteLine("Bravo!!!  tu as utilisé " + ne + " essais");
                }
                else if (enter == "echap")

            {
                Console.WriteLine("merci d'avoir joué");
            }
            }
        }
    }

