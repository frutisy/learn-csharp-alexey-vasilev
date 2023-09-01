using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Создание массива символов с большими английскими согласными буквами";

            int size = 10;
            char[] consonantLetters = new char[size];

            int i = 0;
            char symbol = 'A';

            while (i < size)
            {
                switch (symbol)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'Y':
                        break;
                    default:
                        consonantLetters[i] = symbol;
                        i++;
                        break;
                }
                symbol++;
            }

            Console.WriteLine($"Массив из {size} символов с большими английскими согласными буквами:");

            foreach (char letter in consonantLetters) 
                Console.Write($"{letter} ");

            Console.WriteLine();
        }
    }
}
