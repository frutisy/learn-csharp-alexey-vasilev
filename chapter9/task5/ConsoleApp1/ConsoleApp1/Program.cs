using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс с генератора нечётных чисел";


            Console.WriteLine($"Текущее нечетное число: {OddNumberGenerator.CurrentValue}");
            Console.WriteLine($"Текущее нечетное число: {OddNumberGenerator.CurrentValue}");

            OddNumberGenerator.CurrentValue = 5;

            Console.WriteLine($"Текущее нечетное число: {OddNumberGenerator.CurrentValue}");
            Console.WriteLine($"Текущее нечетное число: {OddNumberGenerator.CurrentValue}");

            OddNumberGenerator.CurrentValue = 1;

            Console.WriteLine($"Текущее нечетное число: {OddNumberGenerator.CurrentValue}");
            Console.WriteLine($"Текущее нечетное число: {OddNumberGenerator.CurrentValue}");



            Console.WriteLine();
        }
    }
}
