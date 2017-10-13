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
            Console.WriteLine("Введите имя первого игрока");
            string a = Console.ReadLine();
            Console.WriteLine("Введите имя второго игрока");
            string b = Console.ReadLine(); ;
            Console.WriteLine("Введите рейтинг первого игрока");
            string e = Console.ReadLine();
            int f = Convert.ToInt32(e);
            Console.WriteLine("Введите рейтинг второго игрока");
            string g = Console.ReadLine();
            int h = Convert.ToInt32(g);
            if (f > h)
            {
                Console.WriteLine("Результат:" + a + b);
                Console.ReadLine();



            }
        }
    }
}
