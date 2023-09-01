using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Находит наименьшее и наибольшее значения среди переданных аргументов.
        /// </summary>
        /// <param name="numbers">Целочисленные аргументы, среди которых ищутся минимальное и максимальное значения.</param>
        /// <returns>Массив из двух элементов, содержащий минимальное и максимальное значения.</returns>
        static int[] FindMinMaxValues(params int[] numbers)
        {
            int minValue = numbers[0];
            int maxValue = numbers[0];

            for (int i = 1; i < numbers.Length; i++) 
            { 
                if (numbers[i] < minValue)
                    minValue = numbers[i];

                if (numbers[i] > maxValue)
                    maxValue = numbers[i];
            }

            return new int[2] { minValue, maxValue };
        }

        static void Main(string[] args)
        {
            int[] minMaxValues = FindMinMaxValues(-3, 0, 27, -15, 93);

            Console.WriteLine($"Передаваемые параметры: {-3}, {0}, {27}, {-15}, {93}");
            Console.WriteLine($"Минимальное значение: {minMaxValues[0]}");
            Console.WriteLine($"Максимальное значение: {minMaxValues[1]}");

            Console.WriteLine();
        }
    }
}
