using System;


namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("hello, " + name);
            Console.WriteLine("how much sleep did you have");
            int hoursOFSleep = int.Parse(Console.ReadLine());
            if (hoursOFSleep < 8)
            { 
                Console.WriteLine("you must feel tierd " + name); 
            }
            else
            {
                Console.WriteLine("you must be well rested " + name);
            }

        }
    }
}
