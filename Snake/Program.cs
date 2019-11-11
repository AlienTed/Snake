using Snake.Classes;
using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 3, '*');
            point1.Draw();

            Point point2 = new Point(4, 5, '#');
            point2.Draw();

            HorizontalLine horizontalLine = new HorizontalLine(5, 10, 8, '+');
            horizontalLine.Draw();

            Console.ReadKey();
        }
    }
}
