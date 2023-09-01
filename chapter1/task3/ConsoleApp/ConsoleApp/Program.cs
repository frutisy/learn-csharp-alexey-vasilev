using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Дата";

            string weekday, month, date;

            Console.Write("Введите день недели: ");
            weekday = Console.ReadLine();

            Console.Write("Введите название месяца: ");
            month = Console.ReadLine();

            Console.Write("Введите номер дня в месяце: ");
            date = Console.ReadLine();

            string fullDate = $"{weekday}, {date}, {month}";
            Console.WriteLine(fullDate);
        }
    }
}
