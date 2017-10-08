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
            Console.WriteLine("Если вы хотите купить GTA 5 введите 1, если NFS51 - введите 2,если StarCraft- введите 3.");
            Console.ReadLine();
            string game = Console.ReadLine();
            int games = Convert.ToInt32("game");
            if (games = 1)
            {
                Console.WriteLine("Вы выбрали GTA 5");
            }
            else (games = 2);
            {
                Console.WriteLine("Вы выбрали NFS51");
            }
            else (games = 3);
            {
                Console.WriteLine("Вы выбрали StarCraft");
            }

            Console.WriteLine("Введите свой баланс");
            string balanc = Console.ReadLine();
            int balance = Convert.ToInt32("balanc");
            if (balance < 250)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else (balance > 250);
            {
                double a = balance - 250;
                Console.WriteLine("Спасибо за покупку!" + a);
            }
        }
    }
}
