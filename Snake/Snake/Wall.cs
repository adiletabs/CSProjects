using System;
using System.IO;

namespace Snake
{
    public class Wall:GameObject
    {
        public Wall(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }

        public Wall()
        {
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(sign);
            }
        }

        public void LoadLevel(string lev)
        {
            string lname = "";

            switch (lev)
            {
                case "1":
                    lname = @"Levels\Level1.txt";
                    break;
                case "2":
                    lname = @"Levels\Level2.txt";
                    break;
                case "3":
                    lname = @"Levels\Level3.txt";
                    break;
                case "inf":
                    lname = @"Levels\LevelInf.txt";
                    break;
                default:
                    break;
            }

            FileStream fs = new FileStream(lname, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line;
            int y = 0;

            while ((line = sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == '#')
                    {
                        this.body.Add(new Point { X = x, Y = y });
                    }
                }
                y++;
            }

            sr.Close();
            fs.Close();
        }
    }
}
