using System;

namespace Snake
{
    public class Worm:GameObject
    {
        public int DX { get; set; }
        public int DY { get; set; }

        public Worm()
        {
        }

        public Worm(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(body[0].X, body[0].Y);
            Console.Write('o');
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 1; i < body.Count; i++)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write('o');
            }
        }

        public void Move()
        {
            int newx = body[0].X + DX;
            int newy = body[0].Y + DY;

            if (newx == 58) newx = 1;
            if (newy == 22) newy = 6;
            if (newx == 0) newx = 57;
            if (newy == 5) newy = 21;

            Point newHead = new Point { X = newx, Y = newy };

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }

            body[0] = newHead;
        }

        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(body[body.Count - 1].X, body[body.Count - 1].Y);
            Console.Write(' ');
        }
    }
}
