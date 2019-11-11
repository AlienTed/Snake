using System.Collections.Generic;

namespace Snake.Classes
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            points = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                points.Add(new Point(x, y, symbol));
            }
        }
    }
}
