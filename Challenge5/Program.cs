using System;
using Core;

namespace Challenge5
{
    class Program
    {
        // Умовистов Андрей
        //5.
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) Сделать задание, только вывод организуйте в центре экрана
        //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
        static void Main(string[] args)
        {

            var programName = "Информация";
            Helpers.Print(programName, (Console.WindowWidth - programName.Length) / 2, 2, ConsoleColor.Red);


            var info = "Умовистов Андрей, г. Москва";
            Helpers.Print(info, (Console.WindowWidth - info.Length) / 2, Console.WindowHeight / 2, ConsoleColor.Green);
            Helpers.Footer();

        
        }

       

        
    }
}
