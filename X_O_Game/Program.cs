using System;
using X_O_Game;
using X_O_Game.Intro;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroTheGame.InicializeGame();
            Menu.GameMenu();
        }
    }
}