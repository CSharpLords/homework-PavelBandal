using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Beep();
            Console.WriteLine("Введите грузоподъёмнность корабля.");
            int maxmassa = int.Parse(Console.ReadLine());
            int power = 0;
            {
                while (true)
                {
                    if (power<maxmassa)
                    {
                        Console.WriteLine("Введите вес коровы.(Если корова жирнее слона не берите её!!!)");
                        int massaa = int.Parse(Console.ReadLine());
                        power = power + massaa;
                    }
                    else
                    {
                        Console.WriteLine("Улетайте");
                        break;
                    }
                }
            }
        }
    }
}
      
       

        


        
