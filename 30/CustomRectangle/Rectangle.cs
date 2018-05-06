using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRectangle
{
    public class Rectangle
    {
        public int a = 0;
        public int x;
        public int y;
        public int width;
        public int height;
        public string symbol;

        public void Draw()
        {
            if (x == width&& y == height)
            {
                a = a + 1;
            }
            Console.SetCursorPosition(x, y);
            for (;a < 1;)
            {
            }
            Console.WriteLine(symbol);
        }
    }
}
