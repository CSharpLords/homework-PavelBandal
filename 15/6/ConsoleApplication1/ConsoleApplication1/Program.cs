using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRost{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] growth = new int[12];
            for (int i = 0; i < growth.Length; i = i + 1)
            {
                int r = rand.Next(163, 190);
                growth[i] = r;
                Console.WriteLine(growth[i]);
            }
            Console.ReadLine();
        }
    }
}