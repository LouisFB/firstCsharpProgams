using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ionepasouvrir
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            string chemin = @"C:\dev";
            string cheminSansNom = "";
            bool FinDuProg = false;
            do
            {
                cheminSansNom = Path.GetDirectoryName(chemin);
                bool result2 = File.Exists(chemin);
                bool result1 = Directory.Exists(cheminSansNom);

                if (result1 == true)
                {
                    if (result2 == false)
                    {
                        using (StreamWriter file = new StreamWriter(chemin, true))
                        {
                            do
                            {
                                n++;
                                file.WriteLine(DateHeure());
                            }
                            while (n <= 5);
                            FinDuProg = false;
                            Console.WriteLine("fin du programme");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ce fichier existe deja voulez-vous l'écraser ?" + "\n oui/non");
                        string ouinon = Console.ReadLine();
                        if (ouinon == "oui")
                        {
                            File.Delete(@"C:\dev\Write2.txt");
                        }
                        else if (ouinon == "non")
                        {
                            Console.WriteLine("fin du programmes");
                            FinDuProg = true;
                        }
                        else
                        {
                            Console.WriteLine("répondre par oui ou par non");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("ce chemin n'existe pas");
                    FinDuProg = true;
                }
            }
            while (FinDuProg == false);
        }

        static string DateHeure()
        {
            return DateTime.Now.ToString();
        }
    }
}
