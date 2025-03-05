using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O_Game.Intro;

namespace X_O_Game
{
    internal class Rules
    {
        public static void GameRules() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+-------------------+");
            Console.WriteLine("| ZASADY OGÓLNE     |");
            Console.WriteLine("+-------------------+");
            Console.ResetColor();
            Console.WriteLine("\n\n\tPole gry wyznaczane zostaje przez nakreślenie 4 przecinających się linii:\r\n\tdwóch pionowo i dwóch poziomo, z których każda jest podzielona przez dwie prostopadłe do niej linie na trzy równe części.\n" +
                "\r\n\t1. Na poszczególnych polach wyznaczonych przez tę figurę (gdyby wpisać ją w kwadrat,\r\n\tpojedynczym polem byłby kwadrat o krawędzi 1/3 kwadratu opisanego) gracze stawiają na przemian kółko i krzyżyk." +
                "\r\n\t2. Gdy któryś z graczy stworzy linię trzech krzyżyków lub trzech kółek, przekreśla ją i zostaje zwycięzcą." +
                "\r\n\t3. Gdy wszystkie pola są zajęte i nie zostaje utworzona linia, gra kończy się remisem.\n\n");
        }

        public static void HowToPlay()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+-------------------+");
            Console.WriteLine("| OBSŁUGA GRY       |");
            Console.WriteLine("+-------------------+");
            Console.ResetColor();
            Console.WriteLine("\n\n\tW grę należy grać w 2 osoby.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\tGracz 1 ");
            Console.ResetColor();
            Console.Write("posiada sygnature:  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("O");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tGracz 2 ");
            Console.ResetColor();
            Console.Write("posiada sygnature:  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X");
            Console.ResetColor();
            Console.Write("\tZawsze zaczyna ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Gracz 1");
            Console.ResetColor();
            Console.WriteLine(".");
            Console.Write("\tAby narysować swoją sygnaturę w polu gry gracz musi wybrać ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("cyfrę (1-9) ");
            Console.ResetColor();
            Console.WriteLine("wyświetloną na planszy gry.");
            Console.WriteLine("\tPo dokonaniu wyboru. Zostanie wyświetlona zaktualizowana plansza.");
            Console.WriteLine("\tNie można cofnąć ruchu.");
            Console.WriteLine("\tAby przerwać grę możesz w każdej chwili wcisnąć 0, co spowoduje powrót do Menu.");
        }
    }
}
