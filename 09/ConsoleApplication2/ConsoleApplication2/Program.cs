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
            while (true)
            {
                Console.WriteLine("Введите первое число");
                int a =int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b = int.Parse(Console.ReadLine());
                int c = a + b;
                Console.WriteLine("Сумма чисел равна "+ c);
                

            }
        }
    }
}
