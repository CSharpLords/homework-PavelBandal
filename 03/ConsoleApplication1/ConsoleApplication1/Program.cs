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
            Console.WriteLine("введите рост ");
            Console.ReadLine();
            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите вес");
            string c = Console.ReadLine();
            int d = Convert.ToInt32(Console.ReadLine());
            int e = b - 100;
            if (e > d)
            {
                Console.WriteLine("Нужно немного набрать вес");
            }
            else (e < d);
                      {
                Console.WriteLine("Советую сесть на диету");
                      }

            
    






            
             

        }

    }
    }
    

