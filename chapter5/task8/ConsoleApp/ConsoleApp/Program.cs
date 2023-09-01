using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Создает массив целых чисел, состоящий из натуральных чисел, если переданы корректные аргументы.
        /// Если значение параметра stop больше, чем значение параметра start, то возвращается массив,
        /// содержащий натуральные числа, начиная с start и заканчивая stop. Если stop меньше или равно start,
        /// возвращается пустой массив.
        /// </summary>
        /// <param name="start">Начальное значение для массива</param>
        /// <param name="stop">Конечное значение для массива</param>
        /// <returns>Массив целых чисел, содержащий натуральные числа или пустой массив</returns>
        static int[] CreateRangeArray(int start, int stop)
        {
            if (stop > start)
            {
                int[] array = new int[stop - start + 1];

                for (int i = 0; i < array.Length; i++)
                    array[i] = start + i;

                return array;
            }
            else
                return new int[0];
        }

        /// <summary>
        /// Создает массив символов, содержащий последовательность символов от startChar до stopChar,
        /// если переданы корректные аргументы. Если значение параметра stopChar больше, чем значение параметра startChar,
        /// то возвращается массив символов, начинающийся с startChar и заканчивающийся stopChar.
        /// Если stopChar меньше или равен startChar, возвращается пустой массив.
        /// </summary>
        /// <param name="startChar">Первый символ для массива</param>
        /// <param name="stopChar">Последний символ для массива</param>
        /// <returns>Массив символов, содержащий последовательность символов или пустой массив</returns>
        static char[] CreateRangeArray(char startChar, char stopChar)
        {
            if (stopChar > startChar)
            {
                char[] array = new char[stopChar - startChar + 1];

                for (int i = 0; i < array.Length; i++)
                    array[i] = (char)(startChar + i);

                return array;
            }
            else
                return new char[0];
        }

        static void Main(string[] args)
        {
            int start = 3;
            int stop = 9;
            int[] arrayNumbers = CreateRangeArray(start, stop);

            char starChar = 'a';
            char stopChar = 'h';
            char[] arrayCharacters = CreateRangeArray(starChar, stopChar);

            Console.WriteLine($"Целочисленный массив: {string.Join(", ", arrayNumbers)}");
            Console.WriteLine($"Символьный массив: {string.Join(", ", arrayCharacters)}");

            Console.WriteLine();
        }
    }
}
