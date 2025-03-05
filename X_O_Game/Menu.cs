using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_Game
{
    internal class Menu
    {
        public static void GameMenu() 
        {
            MainMenuDraft();

            int key = ConsoleHelper.GetNumberByReadLine();

            MenuOptionsSelector(key);
        }
        private static void MainMenuDraft()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|\tMenu główne:       |");
            Console.WriteLine("+--------------------------+-----+");
            Console.WriteLine("|\t Opcje gry:\t         |");
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine("|\t 1.\tUruchom Gre.     |");
            Console.WriteLine("|\t 0.\tWyjdź z gry.     |");
            Console.WriteLine("+--------------------------------+");
            Console.ResetColor();
        }

        private static void MenuOptionsSelector(int key)
        {
            switch(key)
            {
                case 0:
                    ConsoleHelper.CloseGame();
                    return;
                case 1:
                    RunGameMainMenuMessage();
                    break;
                default:
                    BadKeyMainMenuMessage();
                    GameMenu();
                    break;
            }
        }

        private static void RunGameMainMenuMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tGra zaraz się zacznie");
            Console.ResetColor();
            ConsoleHelper.Countinue();
            Console.ReadLine();
        }

        private static void BadKeyMainMenuMessage()
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tPodana wartość jest niezgodna z dostępnymi opcjami.");
            Console.ResetColor();
            ConsoleHelper.Countinue();
            Console.ReadLine();
        }
    }
}
