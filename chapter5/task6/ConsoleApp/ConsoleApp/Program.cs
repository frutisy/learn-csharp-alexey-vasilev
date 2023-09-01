using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Находит наибольший элемент в двумерном массиве и возвращает его значение.
        /// Также передает индексы (строку и столбец) этого элемента через выходные параметры.
        /// </summary>
        /// <param name="array">Двумерный целочисленный массив</param>
        /// <param name="rowindex">Выходной параметр для индекса строки максимального элемента</param>
        /// <param name="colindex">Выходной параметр для индекса столбца максимального элемента</param>
        /// <returns>Значение наибольшего элемента в массиве</returns>
        static int FindMaxElementAndIndices(int[,] array, out int rowindex, out int colindex)
        {
            rowindex = 0;
            colindex = 0;
            int maxValue = array[rowindex, colindex];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (maxValue < array[i, j])
                    {
                        maxValue = array[i, j];
                        rowindex = i;
                        colindex = j;
                    }
                }
            }

            return array[rowindex, colindex];
        }

        /// <summary>
        /// Выводит двумерный целочисленный массив в консоль.
        /// Каждый элемент массива разделяется пробелом, а каждая строка массива выводится на новой строке.
        /// </summary>
        /// <param name="array">Двумерный целочисленный массив для вывода</param>
        static void Print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write($"{array[i, j]} ");

                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            int[,] array =
            {
                { 0, 1, 2 },
                { 3, 4, 5 },
                { 5, 6, 7 },
                { 7, 8, 9 },
            };

            int rowindex;
            int colindex;
            int maxValue = FindMaxElementAndIndices(array, out rowindex, out colindex);

            Console.WriteLine("Элементы массива:");
            Print2DArray(array);

            Console.WriteLine($"\nМаксимальное значение {maxValue} имеет элемент с индексами [{rowindex}, {colindex}]");

            Console.WriteLine();
        }
    }
}
