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
            Triangle();
        }
        static void Triangle()
        {
            Console.WriteLine("Введите длину 1 стороны.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину 2 стороны.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину 3 стороны.");
            int c = int.Parse(Console.ReadLine());
            int d = a + b;
            int e = a + c;
            int f = b + c;
            if (a < f && b < e && c < d)
            {
                Console.WriteLine("Такой треугольник  может существовать.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Такой треугольник не может существовать.");
                Console.ReadLine();
               
            }
        }
    }
}

