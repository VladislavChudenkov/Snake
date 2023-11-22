using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    enum MaxBounds
    {
        MaxRight = 80,
        MaxBottom = 24
    }
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Random random = new Random();
            Food food = new Food(Food.GenerateRandomPosition(random));

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            snake.ChangeDirection(new Position(0, -1));
                            break;
                        case ConsoleKey.DownArrow:
                            snake.ChangeDirection(new Position(0, 1));
                            break;
                        case ConsoleKey.LeftArrow:
                            snake.ChangeDirection(new Position(-1, 0));
                            break;
                        case ConsoleKey.RightArrow:
                            snake.ChangeDirection(new Position(1, 0));
                            break;
                    }
                }

                snake.Move();
                snake.Draw();

                food.Draw();

                if (snake.GetHead().Left == food.Position.Left && snake.GetHead().Top == food.Position.Top)
                {
                    snake.EatFood();
                    food.Respawn(random);
                }

                Thread.Sleep(100);
            }
        }
    }
}