using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        // Умовистов Андрей
        //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку.
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) *используя вывод со знаком $.
        static void Main(string[] args)
        {
            
            var programName = "Анкета";
            
            Console.SetCursorPosition((Console.WindowWidth - programName.Length)/2, 1);
            Console.WriteLine(programName);

            Console.Write("Введите имя: ");
            var firstName = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            var lastName = Console.ReadLine();

            Console.Write("Введите возраст: ");
            var age = Console.ReadLine();

            Console.Write("Введите рост: ");
            var height = Console.ReadLine();
            
            Console.Write("Введите вес: ");
            var weight = Console.ReadLine();

            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введенные данные:");
            // а) используя склеивание;
            Console.WriteLine("Имя: "+firstName + ", Фамилия: " + lastName + ", Возраст: " + age + ", Рост: " + height + ", Вес: " + weight );

            // б) используя форматированный вывод;
            // Console.WriteLine(String.Format("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", firstName, lastName, age, height, weight));

            // в) *используя вывод со знаком $.
            // Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}, Возраст: {age}, Рост: {height}, Вес: {weight}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();
        }
    }
}
