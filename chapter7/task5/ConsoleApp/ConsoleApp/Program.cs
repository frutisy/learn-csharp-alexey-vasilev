using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Поиск позиций символа в тексте";


            string text = "object-oriented programming";
            Console.WriteLine($"Текст: {text}");

            char characterToFind = 'o';
            Console.WriteLine($"Символ: {characterToFind}");

            int[] positions = FindCharacterPositions(text, characterToFind);

            if (positions.Length == 1 && positions[0] == -1)
                Console.WriteLine($"Символ '{characterToFind}' не найден в тексте.");
            else
                Console.WriteLine($"Символ '{characterToFind}' найден на позициях: {string.Join(", ", positions)}");


            Console.WriteLine();
        }

        static int[] FindCharacterPositions(string text, char character)
        {
            int[] positions = new int[0];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == character)
                {
                    Array.Resize(ref positions, positions.Length + 1);
                    positions[positions.Length - 1] = i;
                }
            }

            if (positions.Length == 0)
                return new int[] { -1 };

            return positions;
        }
    }
}
