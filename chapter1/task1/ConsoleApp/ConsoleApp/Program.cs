using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Знакомство с пользователем";

            string firstName, lastName;

            Console.Write("Введите ваше имя: ");
            firstName = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Приятно познакомиться, {0} {1}!", firstName, lastName);
        }
    }
}
