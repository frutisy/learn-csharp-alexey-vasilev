using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Определение года рождения по возрасту";

            int age;
            int currentYear = 2023;
            int birthday;

            Console.Write("Введите ваш возраст: ");
            age = Int32.Parse(Console.ReadLine());

            birthday = currentYear - age;
            Console.WriteLine($"Год вашего рождения - {birthday.ToString()}");
        }
    }
}
