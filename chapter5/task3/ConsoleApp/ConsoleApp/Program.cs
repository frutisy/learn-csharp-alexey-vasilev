using System;

namespace ConsoleApp
{
    internal class Program
    {
        static int[] TakeFirstElements(int[] array, int quantity)
        {
            if (quantity <= 0)
            {
                // Если quantity не положительное число, вернем пустой массив.
                return new int[0];
            }
            else if (quantity >= array.Length)
            {
                // Если quantity больше или равен длине массива, вернем копию исходного массива.
                int[] copyArray = new int[array.Length];
                Array.Copy(array, copyArray, array.Length);
                return copyArray;
            }
            else
            {
                // Если quantity меньше длины массива, вернем новый массив с нужным количеством элементов.
                int[] resultArray = new int[quantity];
                Array.Copy(array, resultArray, quantity);
                return resultArray;
            }
        }

        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6 };
            int quantityToTake = 10;

            int[] resultArray = TakeFirstElements(originalArray, quantityToTake);

            Console.WriteLine("Исходный массив: " + string.Join(", ", originalArray));
            Console.WriteLine("Результат: " + string.Join(", ", resultArray));
        }
    }
}
