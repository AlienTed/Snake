﻿using System.Collections.Generic;

namespace Snake.Classes
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            points = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                points.Add(new Point(x, y, symbol));
            }
        }
    }
}
