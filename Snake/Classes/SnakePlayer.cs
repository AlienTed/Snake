using System;
using System.Collections.Generic;
using System.Text;

namespace Snake.Classes
{
    class SnakePlayer : Figure
    {

        public SnakePlayer(Point tail, int length, Direction direction)
        {
            points = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                points.Add(p);
            }
        }

    }
}
