using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Создание массива со степенями двойки";

            int size = 11;
            int[] arrayPowersOfTwo = new int[size];

            for (int i = 0; i < size; i++)
                arrayPowersOfTwo[i] = (int)Math.Pow(2, i);

            Console.WriteLine("Массив степеней двойки в прямом порядке:");

            for (int i = 0; i < size; i++)
                Console.Write($"{arrayPowersOfTwo[i]} ");

            Console.WriteLine("\nМассив степеней двойки в обратном порядке:");

            for (int i = size - 1; i >= 0; i--)
                Console.Write($"{arrayPowersOfTwo[i]} ");

            Console.WriteLine();
        }
    }
}
