using System;
using System.Collections.Generic;
using System.Text;

namespace Snake.Classes
{
    class Point
    {
        private int x;
        private int y;
        private char symbol;

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
