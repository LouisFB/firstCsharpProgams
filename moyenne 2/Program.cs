using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moyenne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double moy1 = 0;           
            do
            {
                n++;
                Console.WriteLine("entre un nombre");
                double a = int.Parse(Console.ReadLine());
                moy1 += a;
                
                Console.WriteLine("la moyenne est " + (double)moy1 /  n);
            }
           while(true);
        }
    }
}
