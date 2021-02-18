using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Program
    {
        // Умовистов Андрей
        //4. Написать программу обмена значениями двух переменных.
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.
        static void Main(string[] args)
        {
            var programName = "Обмен значениями между переменными";
            Console.SetCursorPosition((Console.WindowWidth - programName.Length) / 2, 1);
            Console.WriteLine(programName);

            Console.Write("Введите значение первой переменной: ");
            Double.TryParse(Console.ReadLine(), out double a);

            Console.Write("Введите значение второй переменной: ");
            Double.TryParse(Console.ReadLine(), out double b);
            Console.Write($"Значения переменных до обмена: ");
            Console.WriteLine($"{a} и {b}");

            Console.WriteLine("Производим обмен...");
            // а) с использованием третьей переменной;

            var temp = a;
            a = b;
            b = temp;

            Console.Write($"Значения переменных после обмена: ");
            Console.WriteLine($"{a} и {b}");

            Console.WriteLine("и обратно..");
            // б) *без использования третьей переменной.
            a = a + b;
            b = a - b;
            a = a - b;

            Console.Write($"Значения переменных после обмена: ");
            Console.WriteLine($"{a} и {b}");

       
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();

        }
    }
}
