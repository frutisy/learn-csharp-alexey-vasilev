using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Меняет порядок элементов в одномерном символьном массиве попарно.
        /// Элементы массива меняются местами таким образом: первый элемент с последним,
        /// второй элемент с предпоследним и так далее.
        /// </summary>
        /// <param name="array">Ссылка на одномерный символьный массив, который будет изменен</param>
        static void SwapElementsInArray(ref char[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                char temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }

        static void Main(string[] args)
        {
            char[] array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

            Console.WriteLine($"Символьный массив до перестановки элементов: {string.Join(", ", array)}");

            SwapElementsInArray(ref array);

            Console.WriteLine($"Символьный массив после перестановки элементов: {string.Join(", ", array)}");

            Console.WriteLine();
        }
    }
}
