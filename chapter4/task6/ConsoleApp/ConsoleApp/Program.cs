using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сортировка целочисленного массива по убыванию значений";

            Random random = new Random();
            int[] numbers = new int[random.Next(10, 21)];

            // Заполнение массива случайными числами.
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(10);

            Console.WriteLine("Массив до сортировки:");

            foreach (int number in numbers)
                Console.Write($"{number} ");

            // Сортировка массива по убыванию значений.
            for (int i = 1; i < numbers.Length; i++) 
            {
                for (int j = 0; j < numbers.Length - i; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nМассив после сортировки по убыванию:");

            foreach (int number in numbers)
                Console.Write($"{number} ");

            Console.WriteLine();
        }
    }
}
