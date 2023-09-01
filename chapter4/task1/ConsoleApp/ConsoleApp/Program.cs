using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "создание массива чисел, делящихся на 5 с остатком 2";

            int size = 0;

            try
            {
                Console.Write("Введите размер массива: ");
                size = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели некорректное значение!");
                Environment.Exit(0);
            }

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
                numbers[i] = 5 * i + 2;

            Console.WriteLine("Массив:");

            for (int i = 0; i < size; i++)
                Console.Write($"{numbers[i]} ");

            Console.WriteLine();
        }
    }
}
