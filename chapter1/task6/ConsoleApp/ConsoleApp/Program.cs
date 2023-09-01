using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вывод имени пользователя и его возраста";

            string name;
            int birthday;
            int currentYear = 2023;

            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.Write("Введите год вашего рождения: ");
            birthday = Int32.Parse(Console.ReadLine());

            int age = currentYear - birthday;

            string message = $"Ваше имя - {name}. Ваш возраст - {age.ToString()}";
            Console.WriteLine(message);
        }
    }
}
