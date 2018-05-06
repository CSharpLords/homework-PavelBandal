using System;

namespace PashaAsteriskLine
{

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.x = 2;
            rect1.y = 2;
            rect1.width = 3;
            rect1.height = 3;
            rect1.symbol = "C";
            rect1.Draw();

            Rectangle rect2 = new Rectangle();
            rect2.x = 7;
            rect2.y = 2;
            rect2.width = 5;
            rect2.height = 4;
            rect2.symbol = "#";
            rect2.Draw();

            Console.ReadLine();
        }
    }
}