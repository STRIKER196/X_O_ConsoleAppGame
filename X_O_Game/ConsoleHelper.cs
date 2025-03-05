using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_Game
{
    internal class ConsoleHelper
    {
        public static void Countinue()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t### Wciśnij dowolony przycisk, aby kontynuuwać. ###");
            Console.ResetColor();
        }

        public static int GetNumberByReadLine()
        {
            do
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                if(int.TryParse(pressedKey.KeyChar.ToString(), out int key))
                {
                    return key;
                }
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Wprowadz odpowiednią cyfrę");
                Console.ResetColor();
            }while (true);
        }
        public static void CloseGame()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\tDziękuje, do zobaczenia :)");
            Countinue();
        }
    }
}
