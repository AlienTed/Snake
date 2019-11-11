using Snake.Classes;
using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            point1.x = 1;
            point1.y = 3;
            point1.symbol = '*';
            point1.Draw();

            Point point2 = new Point();
            point2.x = 4;
            point2.y = 5;
            point2.symbol = '#';
            point2.Draw();

            Console.ReadKey();
        }
    }
}
