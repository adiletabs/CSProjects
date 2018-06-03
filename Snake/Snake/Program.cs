using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();

            game.LoadLevel1();
            game.Start();

            while (game.alive)
            {
                ConsoleKeyInfo pressedButton = Console.ReadKey();
                game.Process(pressedButton);
            }
        }
    }
}
