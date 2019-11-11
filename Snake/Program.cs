using Snake.Classes;
using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine topBoarder = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomBoarder = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftBoarder = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightBoarder = new VerticalLine(0, 24, 78, '+');

            topBoarder.Draw();
            bottomBoarder.Draw();
            leftBoarder.Draw();
            rightBoarder.Draw();

            SnakePlayer snake = new SnakePlayer(new Point(4, 5, '*'), 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadKey();
        }
    }
}
