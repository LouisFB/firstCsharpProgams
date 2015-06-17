using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            int moy = 0;
            Console.WriteLine("give 5 numbers");
           int un = int.Parse(Console.ReadLine());
            int deux = int.Parse(Console.ReadLine());
            int trois = int.Parse(Console.ReadLine());
            int quatre = int.Parse(Console.ReadLine());
            int cinq = int.Parse(Console.ReadLine());

            moy = (un + deux + trois + quatre + cinq)/5;

            Console.WriteLine("la moyenne est de " + moy);

        }
    }
}
