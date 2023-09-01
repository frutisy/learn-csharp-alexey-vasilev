using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Создание массива символов с буквами через одну";

            int size = 10;
            char[] symbols = new char[size];

            char symbol = 'a';

            for (int i = 0; i < size; i++)
            {
                symbols[i] = symbol;
                symbol = (char)((int)symbol + 2);
            }

            Console.WriteLine("Массив символов с буквами черед одну в прямом порядке:");

            for (int i = 0; i < size; i++)
                Console.Write($"{symbols[i]} ");

            Console.WriteLine("\nМассив символов с буквами черед одну в обратном порядке:");

            for (int i = size - 1; i >= 0; i--)
                Console.Write($"{symbols[i]} ");

            Console.WriteLine();
        }
    }
}
