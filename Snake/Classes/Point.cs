using System;

namespace Snake.Classes
{
    class Point
    {
        private int x;
        private int y;
        private char symbol;

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.symbol = point.symbol;
        }

        public void SetSymbol(char symbol)
        {
            this.symbol = symbol;
        }

        public char GetSymbol()
        {
            return symbol;
        }

        public void Move(int offset, Direction direction)
        {
            switch(direction)
            {
                case Direction.RIGHT:
                    x += offset;
                    break;
                case Direction.LEFT:
                    x -= offset;
                    break;
                case Direction.UP:
                    y -= offset;
                    break;
                case Direction.DOWN:
                    y += offset;
                    break;
            }
        }

        internal void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        internal bool IsHit(Point food)
        {
            return this.x == food.x && this.y == food.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symbol;
        }
    }
}
