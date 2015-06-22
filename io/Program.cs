using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace io1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            string chemin = @"C:\dev\Write2.txt";
            string cheminSansNom = "";

            cheminSansNom = Path.GetDirectoryName(chemin);

         bool result = Directory.Exists(cheminSansNom);
         if (result == true)
         {

             using (System.IO.StreamWriter file = new System.IO.StreamWriter(chemin, true))
             {
                 do
                 {
                     n++;
                     file.WriteLine(DateHeure());
                 }
                 while (n <= 5);
             }
         }
         else
         {
             Console.WriteLine("ce chemin n'existe pas");
         }
        }

        static string DateHeure()
        {
            return DateTime.Now.ToString();
        }

    }
}
