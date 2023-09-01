using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Определение порядкового номера дня по введённому дню недели";

            var number = 0;

            Console.Write("Введите название дня недели с большой буквы: ");
            var dayOfWeek = Console.ReadLine();

            switch (dayOfWeek) 
            {
                case "Понедельник":
                    number = 1; break;
                case "Вторник":
                    number = 2; break;
                case "Среда":
                    number = 3; break;
                case "Четверг":
                    number = 4; break;
                case "Пятница":
                    number = 5; break;
                case "Суббота":
                    number = 6; break;
                case "Воскресенье":
                    number = 7; break;
                default:
                    Console.WriteLine("Вы неверно ввели день недели");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine($"Дню недели '{dayOfWeek}' соответствует порядковый номер - {number}");
        }
    }
}
