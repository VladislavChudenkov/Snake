using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Food
    {
        public Position Position { get; private set; }

        public Food(Position initialPosition)
        {
            Position = initialPosition;
        }

        public void Respawn(Random random)
        {
            int left = random.Next((int)MaxBounds.MaxRight);
            int top = random.Next((int)MaxBounds.MaxBottom);
            Position = new Position(left, top);
        }

        public void Draw()
        {
            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write("@");
        }

        public static Position GenerateRandomPosition(Random random)
        {
            int left = random.Next((int)MaxBounds.MaxRight);
            int top = random.Next((int)MaxBounds.MaxBottom);
            return new Position(left, top);
        }
    }
}
