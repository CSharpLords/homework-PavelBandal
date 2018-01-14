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
            int[] massiv = { 1, 2, 5, 67, 4, 3, 8 };
            int i = 0;
            int b = i + 1;
            for (int c = 0; c < 8; i++)
            {
                c = c + 1;
                if (massiv[b] > massiv[i])
                {
                    Console.WriteLine(massiv[b]);
                }
                else
                {
                    
                }
            }
            Console.Read();


        }
    }
}

