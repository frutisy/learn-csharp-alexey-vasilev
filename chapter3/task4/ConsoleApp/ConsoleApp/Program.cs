using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Определение дня недели по введённому числу";

            var number = 0;
            var dayOfWeek = "";

            try
            {
                Console.Write("Введите целое число (в диапазоне от 1 до 7): ");
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не целое число!");
                Environment.Exit(0);
            }

            switch (number) 
            {
                case 1:
                    dayOfWeek = "Понедельник";
                    break;
                case 2:
                    dayOfWeek = "Вторник";
                    break;
                case 3:
                    dayOfWeek = "Среда";
                    break;
                case 4:
                    dayOfWeek = "Четверг";
                    break;
                case 5:
                    dayOfWeek = "Пятница";
                    break;
                case 6:
                    dayOfWeek = "Суббота";
                    break;
                case 7:
                    dayOfWeek = "Воскресенье";
                    break;
                default:
                    Console.WriteLine("Введённое число находится вне диапазона!");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine($"Числу {number} соответствует день недели - {dayOfWeek}");
        }
    }
}
