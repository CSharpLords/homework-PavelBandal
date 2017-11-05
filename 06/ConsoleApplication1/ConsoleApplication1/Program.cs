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
            SayHello();
        }
        static void SayHello()
        {
            Console.WriteLine("Enter your name, please.");
            string b = Console.ReadLine();
            Console.WriteLine("Hello,"+b);
            Console.ReadLine();
        }

 
        }
    }

