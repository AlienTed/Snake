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

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while(true)
            {

                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
