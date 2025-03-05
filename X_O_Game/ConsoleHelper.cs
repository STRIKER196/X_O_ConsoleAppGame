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
            Console.WriteLine("\n\n\tWciśnij dowolony przycisk, aby kontynuuwać.");
            Console.ResetColor();
        }
    }
}
