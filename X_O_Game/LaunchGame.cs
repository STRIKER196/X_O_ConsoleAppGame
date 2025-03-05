using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_Game
{
    internal class LaunchGame
    {
        public static void BeforeGame()
        {
            Rules.GameRules();
            Rules.HowToPlay();
            StartGame();
            Game();
        }
        public static void Game()
        { 

            AfterGame();
        }
        public static void AfterGame()
        {
            Console.ReadLine();
        }
        private static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n+-------------------+");
            Console.WriteLine("| START GRY         |");
            Console.WriteLine("+-------------------+\n\n");
            Console.ResetColor();
            ConsoleHelper.Countinue();
        }
    }
}
