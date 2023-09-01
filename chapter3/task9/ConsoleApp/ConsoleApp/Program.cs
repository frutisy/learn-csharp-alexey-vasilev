using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вывод диапазона чисел";

            var number1 = 0;
            var number2 = 0;
            
            try
            {
                Console.Write("Введите первое число: ");
                number1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                number2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException) 
            {
                Console.WriteLine("Ошибка: введено некорректное значение");
                Environment.Exit(0);
            }

            for (int i = number1; i <= number2; i++)
            {
                Console.WriteLine($"Число: {i}");
            }
        }
    }
}
