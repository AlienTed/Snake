using System.Collections.Generic;

namespace Snake.Classes
{
    abstract class Figure
    {
        protected List<Point> points;
        public void Draw()
        {
            foreach (var point in points)
                point.Draw();
        }
    }
}
