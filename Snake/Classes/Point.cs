using System;
using System.Collections.Generic;
using System.Text;

namespace Snake.Classes
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
