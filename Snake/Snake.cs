using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        private List<Position> snakeBody;
        private int length;
        private Position direction;
        public Position GetHead()
        {
            return snakeBody[0];
        }

        public Snake()
        {

            length = 1;
            snakeBody = new List<Position>();
            snakeBody.Add(new Position(10, 10));
            direction = new Position(1, 0);
        }


        public void Move()
        {

            Position newHead = snakeBody[0] + direction;


            if (newHead.Left < 0 || newHead.Left >= (int)MaxBounds.MaxRight ||
                newHead.Top < 0 || newHead.Top >= (int)MaxBounds.MaxBottom)
            {
                Console.WriteLine("Игра окончена!");
                Environment.Exit(0);
            }


            snakeBody.Insert(0, newHead);


            if (snakeBody.Count > length)
            {
                snakeBody.RemoveAt(snakeBody.Count - 1);
            }

        }


        public void ChangeDirection(Position newDirection)
        {
            if (newDirection.Left + direction.Left != 0 || newDirection.Top + direction.Top != 0)
            {
                direction = newDirection;
            }
        }

        public void Draw()
        {
            Console.Clear();
            for (int i = 0; i < snakeBody.Count; i++)
            {
                Position position = snakeBody[i];
                Console.SetCursorPosition(position.Left, position.Top);
                Console.Write("*");
            }
        }

        public void EatFood()
        {
            length++;
        }
    }
}
