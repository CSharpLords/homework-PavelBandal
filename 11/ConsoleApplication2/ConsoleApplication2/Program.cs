using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("\n20 random integers from -100 to 100:");
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                Console.Write("{0,6}", rnd.Next(-100, 101));
                if (ctr % 5 == 0) Console.WriteLine();
            }

            Console.WriteLine("\n20 random integers from 1000 to 10000:");
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                Console.Write("{0,8}", rnd.Next(1000, 10001));
                if (ctr % 5 == 0) Console.WriteLine();
            }

            Console.WriteLine("\n20 random integers from 1 to 10:");
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                Console.Write("{0,6}", rnd.Next(1, 11));
                if (ctr % 5 == 0) Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
