using Snake.Classes;
using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Drawing a frame
            HorizontalLine topBoarder = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomBoarder = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftBoarder = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightBoarder = new VerticalLine(0, 24, 78, '+');

            topBoarder.Draw();
            bottomBoarder.Draw();
            leftBoarder.Draw();
            rightBoarder.Draw();

            //Adding a snake to the scene
            SnakePlayer snake = new SnakePlayer(new Point(4, 5, '*'), 4, Direction.RIGHT);
            snake.Draw();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HanleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadKey();
        }
    }
}
