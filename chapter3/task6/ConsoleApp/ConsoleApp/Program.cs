using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сумма нечётных чисел";

            var sumOfOddNumbers = 0;

            Console.Write("Введите количество нечётных чисел: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                sumOfOddNumbers += 2 * i + 1;
            }

            Console.WriteLine($"Сумма {n} нечётных чисел равна {sumOfOddNumbers}"); 
        }
    }
}
