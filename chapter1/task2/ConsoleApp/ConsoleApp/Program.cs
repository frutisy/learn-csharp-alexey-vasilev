using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Имя и возраст пользователя";

            string name, age;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}");
            Console.WriteLine($"Ваш возраст - {age} лет");
        }
    }
}
