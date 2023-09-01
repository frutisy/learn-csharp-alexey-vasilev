using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Поиск минимального элемента в случайном массиве чисел";

            Random random = new Random();
            int[] numbers = new int[random.Next(30, 41)];

            // Заполнение массива случайными числами.
            for (int i = 0; i < numbers.Length; i++) 
                numbers[i] = random.Next(100);

            Console.WriteLine($"Массив из {numbers.Length} случайных чисел:");

            foreach (int number in numbers) 
                Console.Write($"{number} ");

            int minValue = numbers[0];
            
            // Поиск минимального значения.
            for (int i = 1; i < numbers.Length; i++) 
            { 
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }

            int numberOfIndexes = 0;

            // Подсчёт количества индексов чисел с минимальным значением.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == minValue)
                {
                    numberOfIndexes++;
                }
            }

            int[] indexes = new int[numberOfIndexes];
            int j = 0;

            // Добавление индексов чисел с минимальным значением в массив индексов.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == minValue) 
                {
                    indexes[j] = i;
                    j++;
                }
            }

            Console.WriteLine($"\nМинимальное значение - {minValue}");
            Console.Write("Индекс(ы): ");
            
            foreach (int index in indexes) 
                Console.Write($"{index} ");

            Console.WriteLine();
        }
    }
}
