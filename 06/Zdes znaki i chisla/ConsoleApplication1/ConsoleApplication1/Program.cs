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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first second, please.");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(">");
                Console.ReadLine();
            }
            else if (b > a)
            {
                Console.WriteLine("<");
                Console.ReadLine();
            }
            else if (b == a)
            {
                Console.WriteLine("=");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Perezapusti programmu i vvedi normalnoe chislo, lomatel pravil herov");
                Console.ReadLine();
            }
        }
    }
}
