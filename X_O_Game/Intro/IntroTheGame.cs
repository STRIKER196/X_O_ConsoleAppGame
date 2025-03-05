using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_Game.Intro
{
    internal class IntroTheGame
    {
        public static void InicializeGame()
        {
            GameVersion();
            GameIntro();
            RunTheGame();
        }

        private static void RunTheGame()
        {
            ConsoleHelper.Countinue();
            Console.ReadLine();
            Console.Clear();
        }

        private static void GameIntro()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+---------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\tKółko i krzyżyk – gra strategiczna rozgrywana przez dwóch graczy, najczęściej na kartce w kratkę.                                           |\n" +
                              "|\tGracze obejmują pola na przemian dążąc do objęcia trzech pól w jednej linii, przy jednoczesnym uniemożliwieniu tego samego przeciwnikowi.   |\n" +
                              "|\tPole może być objęte przez jednego gracza i nie zmienia swego właściciela przez cały przebieg gry.                                          |\n" +
                              "|\tW najbardziej popularnej w Polsce wersji gra odbywa się na polu o wymiarach 3x3.                                                            |");
            Console.WriteLine("+---------------------------------------------------------------------------------------------------------------------------------------------------+\n");
            Console.ResetColor();
        }
        private static void GameVersion()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+-------------------+");
            Console.WriteLine("| X  O  Game   v0.1 |");
            Console.WriteLine("+-------------------+\n\n\n\n\n");
            Console.ResetColor();
        }
    }
}
