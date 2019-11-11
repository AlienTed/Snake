using System;
using System.Collections.Generic;
using System.Text;

namespace Snake.Classes
{
    class HorizontalLine
    {
        List<Point> points;

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            points = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                points.Add(new Point(x, y, symbol));
            }
        }

        public void Draw()
        {
            foreach (var point in points)
                point.Draw();
        }
    }
}
