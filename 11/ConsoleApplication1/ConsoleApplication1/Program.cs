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
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            char letter = str[1];
            Console.WriteLine(letter == 'ж');
            Console.WriteLine(letter);
            Console.WriteLine(str.Length);
            Console.ReadLine();

        }
    }
}
