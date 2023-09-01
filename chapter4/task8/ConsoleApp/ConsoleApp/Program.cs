using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Изменение строк и столбцов в двумерном массиве";

            Random random = new Random();

            int rows = 3;
            int cols = 5;
            int[,] numbers = new int[rows, cols];

            for (int i = 0; i < rows; i++) 
            { 
                for (int j = 0; j < cols; j++)
                    numbers[i, j] = random.Next(10);
            }

            int[,] newNumbers = new int[cols, rows];

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    newNumbers[i, j] = numbers[j, i];
            }

            Console.WriteLine($"Массив numbers[{rows}, {cols}]:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{numbers[i, j]} ");
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine($"Массив newNumbers[{cols}, {rows}]:");

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{newNumbers[i, j]} ");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
