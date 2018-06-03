using System;
using System.Timers;

namespace Snake
{
    class Game
    {
        Worm worm;
        Wall wall;
        Food food;

        public void DrawField()
        {
            Console.SetWindowSize(60, 25);
            Console.SetBufferSize(60, 25);
            Console.CursorVisible = false;

            Console.SetCursorPosition(25, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('S');
            Console.SetCursorPosition(27, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('N');
            Console.SetCursorPosition(29, 1);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write('A');
            Console.SetCursorPosition(31, 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('K');
            Console.SetCursorPosition(33, 1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write('E');

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(2, 4);
            Console.Write("Points: ");
            Console.SetCursorPosition(25, 4);
            Console.Write("Speed: 100");
            Console.SetCursorPosition(48, 4);
            Console.Write("Level: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 3);
            for (int i = 0; i < 58; i++) Console.Write('_');
            Console.SetCursorPosition(1, 5);
            for (int i = 0; i < 58; i++) Console.Write('_');
            Console.SetCursorPosition(0, 4);
            for (int i = 0; i < 19; i++) Console.WriteLine('|');
            for (int i = 0; i < 19; i++)
            {
                Console.SetCursorPosition(59, 4 + i);
                Console.WriteLine('|');
            }
            Console.SetCursorPosition(1, 22);
            for (int i = 0; i < 58; i++) Console.Write('_');
        }

        public void DrawGameOver()
        {
            Console.Clear();
            worm.body.Clear();
            food.body.Clear();
            wall.body.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(23, 5);
            for (int i = 0; i < 18; i++) Console.Write('_');
            Console.SetCursorPosition(23, 7);
            for (int i = 0; i < 18; i++) Console.Write('_');
            Console.SetCursorPosition(23, 15);
            for (int i = 0; i < 18; i++) Console.Write('_');
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(22, 6 + i);
                Console.WriteLine('|');
            }
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(41, 6 + i);
                Console.WriteLine('|');
            }
            Console.SetCursorPosition(23, 13);
            for (int i = 0; i < 18; i++) Console.Write('_');
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(27, 6);
            Console.Write("GAME OVER");
            Console.SetCursorPosition(24, 8);
            Console.Write("Total points: " + points);
            Console.SetCursorPosition(24, 10);
            Console.Write("Max speed: " + moves);
            Console.SetCursorPosition(24, 12);
            Console.Write("Final level: " + lev);
            Console.SetCursorPosition(26, 14);
            Console.Write("Press Escape");
            Console.SetCursorPosition(1, 23);
        }

        public int points = 0;
        public int pts;
        public string lev = "1";
        public string l;
        public int moves = 100;

        public void DrawBar()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(10, 4);
            Console.Write(points);
            Console.SetCursorPosition(55, 4);
            Console.Write(lev);
        }

        public bool alive = true;
        public bool isPaused = false;

        public void LoadLevel1()
        {
            Console.Clear();
            wall.LoadLevel("1");
            DrawField();
            Draw();
            worm = new Worm(new Point { X = 32, Y = 13 }, ConsoleColor.DarkGreen, 'o');
        }

        public void LoadLevel2()
        {
            Stop();
            Console.Clear();
            worm.body.Clear();
            wall.body.Clear();
            food.body.Clear();
            DrawField();
            wall.LoadLevel("2");
            worm = new Worm(new Point { X = 32, Y = 13 }, ConsoleColor.DarkGreen, 'o');
            food = new Food(new Point { X = 20, Y = 14 }, ConsoleColor.Red, '+');
            isPaused = false;
            Draw();
            Start();
        }

        public void LoadLevel3()
        {
            Stop();
            Console.Clear();
            worm.body.Clear();
            wall.body.Clear();
            food.body.Clear();
            DrawField();
            wall.LoadLevel("3");
            worm = new Worm(new Point { X = 32, Y = 13 }, ConsoleColor.DarkGreen, 'o');
            food = new Food(new Point { X = 20, Y = 14 }, ConsoleColor.Red, '+');
            isPaused = false;
            Draw();
            Start();
        }

        public void LoadLevelInf()
        {
            Stop();
            Console.Clear();
            worm.body.Clear();
            wall.body.Clear();
            food.body.Clear();
            DrawField();
            wall.LoadLevel("inf");
            worm = new Worm(new Point { X = 32, Y = 13 }, ConsoleColor.DarkGreen, 'o');
            food = new Food(new Point { X = 20, Y = 14 }, ConsoleColor.Red, '+');
            isPaused = false;
            Draw();
            Start();
        }

        public Game()
        {
            alive = true;
            worm = new Worm(new Point { X = 32, Y = 13 }, ConsoleColor.DarkGreen, 'o');
            food = new Food(new Point { X = 20, Y = 14 }, ConsoleColor.Red, '+');
            wall = new Wall(null, ConsoleColor.DarkMagenta, '#');
        }

        public void Draw()
        {
            worm.Draw();
            food.Draw();
            wall.Draw();
        }

        Timer t;

        public void Start()
        {
            t = new Timer
            {
                Interval = 100
            };
            t.Elapsed += DrawWorm;
            t.Start();
        }

        public void Stop()
        {
            t.Stop();
            t.Dispose();
        }

        public void DrawWorm(object sender, ElapsedEventArgs e)
        {
            if (points == 30)
            {
                points = 40;
                LoadLevel2();
            }
            if (points == 70)
            {
                points = 80;
                LoadLevel3();
            }
            if (points == 110)
            {
                points = 120;
                LoadLevelInf();
            }

            DrawBar();
            worm.Clear();
            worm.Move();
            worm.Draw();

            if (worm.body[0].Equals(food.body[0]))
            {
                worm.body.Add(new Point { X = food.body[0].X, Y = food.body[0].Y });
                points = points + 10;
                bool goodFood = false;
                while (!goodFood)
                {
                    food = new Food(new Point { X = new Random().Next() % 57 + 1, Y = new Random().Next() % 15 + 6 }, ConsoleColor.Red, '+');
                    goodFood = true;
                    foreach (Point p in worm.body)
                    {
                        if (food.body[0].Equals(p))
                        {
                            goodFood = false;
                            break;
                        }
                    }
                    foreach (Point p in wall.body)
                    {
                        if (food.body[0].Equals(p))
                        {
                            goodFood = false;
                            break;
                        }
                    }
                }
                food.Draw();
            }

            else
            {
                foreach (Point p in wall.body)
                {
                    if (p.Equals(worm.body[0]))
                    {
                        Stop();
                        alive = false;
                        DrawGameOver();
                    }
                }

                if (worm.body.Count > 1)
                {
                    for (int i = 1; i < worm.body.Count; i++)
                    {
                        if (worm.body[0].Equals(worm.body[i]))
                        {
                            Stop();
                            alive = false;
                            DrawGameOver();
                        }
                    }
                }
            }

            if (points >= 110) lev = "inf";
            else if (points >= 70) lev = "3";
            else if (points >= 30) lev = "2";
        }

        public void Process(ConsoleKeyInfo pressedButton)
        {
            switch (pressedButton.Key)
            {
                case ConsoleKey.LeftArrow:
                    worm.DY = 0;
                    worm.DX = -1;
                    break;
                case ConsoleKey.RightArrow:
                    worm.DY = 0;
                    worm.DX = 1;
                    break;
                case ConsoleKey.UpArrow:
                    worm.DY = -1;
                    worm.DX = 0;
                    break;
                case ConsoleKey.DownArrow:
                    worm.DY = 1;
                    worm.DX = 0;
                    break;
                case ConsoleKey.Spacebar:
                    if (isPaused)
                    {
                        isPaused = false;
                        Start();
                    }
                    else
                    {
                        isPaused = true;
                        Stop();
                    }
                    break;
                case ConsoleKey.F1:
                    if (isPaused)
                    {
                        pts = points;
                        l = lev;
                        worm.Save();
                        food.Save();
                        wall.Save();
                    }
                    break;
                case ConsoleKey.F2:
                    if (isPaused)
                    {
                        Console.Clear();
                        DrawField();
                        points = pts;
                        lev = l;
                        worm = worm.Load() as Worm;
                        food = food.Load() as Food;
                        wall = wall.Load() as Wall;
                        Draw();
                    }
                    break;
                case ConsoleKey.Escape:
                    alive = false;
                    Stop();
                    DrawGameOver();
                    break;
                default:
                    break;
            }
        }
    }
}
