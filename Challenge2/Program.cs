using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        // Умовистов Андрей
        //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
        static void Main(string[] args)
        {
            var programName = "Расчет индекса массы тела";
            Console.SetCursorPosition((Console.WindowWidth - programName.Length) / 2, 1);
            Console.WriteLine(programName);


            Console.Write("Введите рост (см): ");
            Double.TryParse(Console.ReadLine(), out double height); ;


            Console.Write("Введите вес (кг): ");
            Double.TryParse(Console.ReadLine(), out double weight); ;

            var index = weight / (height/100 * height/100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Индекс массы тела: {String.Format("{0:F2}",index)}");


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();
        }
    }
}
