using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Определение возраста пользователя";

            int birthday;
            int currentYear = 2023;

            Console.Write("Введите год вашего рождения: ");
            birthday = Int32.Parse(Console.ReadLine());

            int age = currentYear - birthday;

            Console.WriteLine($"Ваш возраст - {age.ToString()}");
        }
    }
}
