using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Количество дней в месяце";

            string month, numberOfDaysInMonth;

            Console.Write("Введите название месяца: ");
            month = Console.ReadLine();

            Console.Write("Введите количество дней в месяце: ");
            numberOfDaysInMonth = Console.ReadLine();

            Console.WriteLine($"В {month} {numberOfDaysInMonth} дней");
        }
    }
}
