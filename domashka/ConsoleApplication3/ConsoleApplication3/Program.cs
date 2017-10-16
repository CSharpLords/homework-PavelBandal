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
            Console.WriteLine("Введите процент кислорода");
            string o = Console.ReadLine();
            int oxygen = int.Parse(o);
            Console.WriteLine("Введите среднюю температуру");
            string t = Console.ReadLine();
            int temperature = int.Parse(t);
            if (oxygen > 20 && temperature > 15)
            {
                Console.WriteLine("Хьюстоон!!!На планете есть жизнь,    но знакомство с ней обернулось потерей руки путём откусывания выше указанной жизнью!!!");
                Console.ReadLine();
            }   
            else
            {
                Console.WriteLine("Хьюстон, планета необитаема.");
            }   Console.ReadLine();
        }
    }
}
