using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    // Умовистов Андрей

    /// <summary>
    /// Вспомогательный класс
    /// </summary>
    public class Helpers
    {
        public static void Footer()
        {
            var footer = "Нажмите Enter для выхода";
            Print(footer, (Console.WindowWidth - footer.Length) / 2, Console.WindowHeight - 1);
            Console.ReadLine();
        }

        public static void Print(string message, int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
