using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        // Умовистов Андрей
        //3.
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

        static void Main(string[] args)
        {
            var programName = "Расчет расстояния между точками";
            Console.SetCursorPosition((Console.WindowWidth - programName.Length) / 2, 1);
            Console.WriteLine(programName);

            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("x1 = ");
            Double.TryParse(Console.ReadLine(), out double x1);
            Console.Write("y1 = ");
            Double.TryParse(Console.ReadLine(), out double y1);

            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("x2 = ");
            Double.TryParse(Console.ReadLine(), out double x2);
            Console.Write("y2 = ");
            Double.TryParse(Console.ReadLine(), out double y2);

            double distance = CalculateDistance(x1, y1, x2, y2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Расстояние между точками: {String.Format("{0:F2}", distance)}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();
        }

        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }

}
