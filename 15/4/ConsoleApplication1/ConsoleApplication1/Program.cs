using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пары
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, -23, 3, 3, 99,12 };
            int n = 0;
            int back = 0;
            int next = 1;
            while (n < 1)
            {
                if (numbers[back] > 0 && numbers[next] > 0 || numbers[back] < 0 && numbers[next] < 0 || numbers[back] == 0 && numbers[next] == 0)
                {
                    Console.WriteLine(numbers[back] + " " + numbers[next]);
                    n = n + 1;
                }
                back = back + 1;
                next = next + 1;
                
            }

            Console.ReadKey();
        }
    }
    
}
