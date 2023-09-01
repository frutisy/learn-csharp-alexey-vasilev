using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сумма квадратов натуральных чисел";

            var sumOfSquaresOfNaturalNumbers = 0;

            Console.Write("Введите количество натуральных чисел: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++) 
            {
                sumOfSquaresOfNaturalNumbers += i * i;
            }

            Console.WriteLine($"Сумма квадратов натуральных {n} чисел равна {sumOfSquaresOfNaturalNumbers}");
        }
    }
}
