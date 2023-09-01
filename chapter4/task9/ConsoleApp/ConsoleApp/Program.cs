using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Удаление строки и столбца из двумерного числового массива";

            int[,] numbers = new int[,]
            {
                { 1, 1, 1, 1, 1 },
                { 2, 2, 2, 2, 2 },
                { 3, 3, 3, 3, 3 },
                { 4, 4, 4, 4, 4 },
                { 5, 5, 5, 5, 5 }
            };

            Random random = new Random();

            int rows = numbers.GetLength(0);
            int cols = numbers.GetLength(1);

            Console.WriteLine("Массив до удаления строки и столбца:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{numbers[i, j]} ");

                Console.WriteLine();
            }

            int rowIndexToDelete = random.Next(rows);
            int colIndexToDelete = random.Next(cols);

            Console.WriteLine($"\nСлучайный индекс строки для удаления - {rowIndexToDelete}");
            Console.WriteLine($"Случайный индекс столбца для удаления - {colIndexToDelete}");

            Console.WriteLine($"\nМассив после удаления строки и столбца:");

            for (int i = 0; i < rows; i++)
            {
                if (i == rowIndexToDelete) continue;

                for (int j = 0; j < cols; j++)
                {
                    if (j == colIndexToDelete) continue;

                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
