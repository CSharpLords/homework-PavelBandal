using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteNumber();
        }
        static void WriteNumber()
        {
            Console.WriteLine("Enter first number, please.");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number, please.");
            int second = int.Parse(Console.ReadLine());
            if (first > 0 && second > 0)
            {
                Console.WriteLine("+");
                Console.ReadLine();
            }
            else if (first < 0 && second < 0)
            {
                Console.WriteLine("+");
                Console.ReadLine();
            }
            else if (first == 0 && second == 0)
            {
                Console.WriteLine("+");
                Console.ReadLine();
            }
                 else
                 {
                    Console.WriteLine("=");
                    Console.ReadLine();
                
            }
        }
    }
}
