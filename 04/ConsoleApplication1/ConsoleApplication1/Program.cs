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

            int max1 = Max();
            int max2 = Max();
            MaxV2(max1, max2);

            Console.ReadLine();
        }

        static int Max()
        {
            int[] arr = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите число");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Наибольшее число:=  " + arr.Max());
            return arr.Max();
        }

        static void MaxV2(int max1, int max2)
        {
            if (max1 > max2)
                Console.WriteLine("Наибольшее число из {0} и {1}:= {0} ", max1, max2);
            else
                Console.WriteLine("Наибольшее число из {0} и {1} := {1} ", max1, max2);
        }
    }
}

