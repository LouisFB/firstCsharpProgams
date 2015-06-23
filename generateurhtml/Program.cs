using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace generateurhtml
{
    class Program
    {
        static void Main(string[] args)
        {
            int ajouterLargeur = 0;
            int ajouterHauteur = 0;
            string choixOption = "";
            string titre = "";
            List<string> elements = new List<string>();
            string chemin = @"C:\dev\Write3.html";
            string para1 = "";
            string titrePara = "";
            string ajouterimage = "";
            bool finDuProg = false;
            int caseOption = 0;
            File.Delete(@"C:\dev\Write3.html");
           
            do
            {

                Console.WriteLine(" 1 = paragraphe");
                Console.WriteLine(" 2 = titreDePara");
                Console.WriteLine(" 3 = titreDePage");
                Console.WriteLine(" 4 = ajouter une image");
                Console.WriteLine(" 5 = echap");

                choixOption = Console.ReadLine();

                string message = test(choixOption);
                if (String.IsNullOrEmpty(message))
                {
                    caseOption = Int32.Parse(choixOption);
                    switch (caseOption)
                    {
                        case 1:

                            Console.WriteLine("entrez du texte");
                            para1 = Console.ReadLine();
                            elements.Add(paragraphe(para1));
                            Console.Clear();
                            break;

                        case 2:

                            Console.WriteLine("donez un titre a votre paragraphe");
                            titrePara = Console.ReadLine();
                            elements.Add(titreDePara(titrePara));
                            Console.Clear();
                            break;

                        case 3:

                            Console.WriteLine("donez un titre a votre page");
                            titre = titreDePage(Console.ReadLine());
                            Console.Clear();
                            break;

                        case 4:
                             Console.WriteLine("entrez une image");
                             ajouterimage = Console.ReadLine();
                            Console.WriteLine("entrez la largeur");
                             ajouterLargeur = int.Parse(Console.ReadLine());
                            Console.WriteLine("entrez la hauteur");
                              ajouterHauteur= int.Parse(Console.ReadLine());
                            elements.Add(ajouterImage(ajouterimage, ajouterLargeur, ajouterHauteur));
                            Console.Clear();
                            break;
             
                        case 5:
                            finDuProg = true;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(message);    
                }
            }
            while (!finDuProg);

            using (StreamWriter file = new StreamWriter(chemin, true, Encoding.UTF8))
            {
                file.WriteLine("<html>");
                file.WriteLine("<head>");
                file.WriteLine(@"<meta charset=""utf-8""/>");
                file.WriteLine(titre);
                file.WriteLine("</head>");
                file.WriteLine("<body>");
                file.WriteLine(String.Join("\n", elements.ToArray()));
                file.WriteLine("</body>");
                file.WriteLine("</html>");
            }

        }
        static string paragraphe(string para1)
        {
            return String.Format("<p>{0}</p>", para1);
        }
        static string titreDePara(string titrePara)
        {
            return String.Format("<h1>{0}</h1>", titrePara);
        }
        static string titreDePage(string titrePage)
        {
            return String.Format("<title>{0}</title>", titrePage);
        }
        static string ajouterImage(string ajouterimage, int ajouterLargeur, int ajouterHauteur)
        {
            return String.Format(@"<img src=""{0}"" width=""{1}px"" height=""{2}px"" />", ajouterimage, ajouterLargeur, ajouterHauteur);
        }


        static string test(string choixOption)
        {
            int caseOption;
            if (Int32.TryParse(choixOption, out caseOption))
            {
                if (caseOption >= 1 && caseOption <= 5)
                {
                    return "";
                }
                else
                {
                    return "ce nombre nest pas valide";
                }
            }
            else
            {
                return "Ce n'est pas un chiffre";
            }
        }
    }
}
