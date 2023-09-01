using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сумма и разность двух чисел";

            int number1, number2, sum, difference;

            Console.Write("Введите первое число: ");
            number1 = Int32.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            number2 = Int32.Parse(Console.ReadLine());

            sum = number1 + number2;
            difference = number1 - number2;

            Console.WriteLine($"Сумма {number1} и {number2} равна {sum}");
            Console.WriteLine($"Разность {number1} и {number2} равна {difference}");
        }
    }
} 