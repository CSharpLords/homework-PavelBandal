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
            ShowMessage();
        }
        static void ShowMessage()
        {
            Console.WriteLine("Введите значение угрозы");
            int znachenie = int.Parse(Console.ReadLine());
            if (znachenie > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Внимание!Внимание!");
            }
            else
            {
                Console.WriteLine("Привет!");
            }
        }
    }
}
