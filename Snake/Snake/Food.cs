using System;

namespace Snake
{
    public class Food:GameObject
    {
        public Food(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {
        }

        public Food()
        {
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(sign);
            }
        }
    }
}
