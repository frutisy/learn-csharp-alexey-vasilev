using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Заполнение двумерного числового массива змейкой";

            int rows = 3;
            int cols = 3;
            int[,] numbers = new int[rows, cols];

            int value = 1; // Значение, которым будем заполнять массив.

            int topRow = 0; // Верхняя граница.
            int bottomRow = rows - 1; // Нижняя граница.
            int leftColumn = 0; // Левая граница.
            int rightColumn = cols - 1; // Правая граница.

            while (topRow <= bottomRow && leftColumn <= rightColumn)
            {
                // Заполнение верхней строки слева направо.
                for (int i = leftColumn; i <= rightColumn; i++)
                {
                    numbers[topRow, i] = value;
                    value++;
                }
                topRow++;

                // Заполнение последнего столбца сверху вниз.
                for (int i = topRow; i <= bottomRow; i++)
                {
                    numbers[i, rightColumn] = value;
                    value++;
                }
                rightColumn--;

                if (topRow <= bottomRow)
                {
                    // Заполнение нижней строки справа налево.
                    for (int i = rightColumn; i >= leftColumn; i--)
                    {
                        numbers[bottomRow, i] = value;
                        value++;
                    }
                    bottomRow--;
                }

                if (leftColumn <= rightColumn)
                {
                    // Заполнение первого столбца снизу вверх.
                    for (int i = bottomRow; i >= topRow; i--)
                    {
                        numbers[i, leftColumn] = value;
                        value++;
                    }
                    leftColumn++;
                }
            }

            Console.WriteLine("Массив, заполненный змейкой:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{numbers[i, j]}\t");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
