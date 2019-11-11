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

            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            numList.RemoveAt(1);

            foreach (var i in numList)
                Console.WriteLine(i);

            List<Point> points = new List<Point>();
            points.Add(point1);
            points.Add(point2);

            Console.ReadKey();
        }
    }
}
