using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Вычисляет среднее значение элементов целочисленного массива.
        /// </summary>
        /// <param name="numbers">Целочисленный массив, для которого требуется вычислить среднее значение.</param>
        /// <returns>Среднее значение элементов массива.</returns>
        static double ComputeAverageValue(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            return (double)sum / numbers.Length;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 22, -33 };
            double averageValue = Math.Round(ComputeAverageValue(numbers), 2);

            Console.WriteLine($"Массив numbers: {string.Join(", ", numbers)}");
            Console.WriteLine($"Среднее значение: {averageValue}");
        }
    }
}
