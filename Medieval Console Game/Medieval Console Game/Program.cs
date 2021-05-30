using System;

namespace Medieval_Console_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            GameLogic gameLogic = new GameLogic();
            gameLogic.WelcomeTitle();
           
        }
    }
}
