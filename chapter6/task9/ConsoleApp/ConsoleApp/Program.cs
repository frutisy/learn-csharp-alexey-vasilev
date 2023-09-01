using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вычисление наибольшего, наименьшего и среднего значения из набора чисел";

            int[] numbers = new int[] { 3, 5, -10, 20, 50, 0, 1, 125 };

            Console.WriteLine($"Целочисленные массив: {string.Join(", ", numbers)}");
            Console.WriteLine($"Максимальное значение: {MathUtils.FindMaximum(numbers)}");
            Console.WriteLine($"Минимальное значение: {MathUtils.FindMinimum(numbers)}");
            Console.WriteLine($"Среднее значение: {MathUtils.CalculateAverage(numbers)}");

            Console.WriteLine();
        }
    }

    class MathUtils
    {
        public static int FindMaximum(params int[] numbers)
        {
            int maxValue = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                    maxValue = numbers[i];
            }

            return maxValue;
        }

        public static int FindMinimum(params int[] numbers)
        {
            int minValue = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                    minValue = numbers[i];
            }

            return minValue;
        }

        public static double CalculateAverage(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];

            return Math.Round((double)sum / numbers.Length, 2);
        }
    }
}
