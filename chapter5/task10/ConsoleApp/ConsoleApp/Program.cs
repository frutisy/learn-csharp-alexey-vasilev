using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Добавляет символьные значения в конец исходного текста.
        /// </summary>
        /// <param name="text">Исходный текст, к которому добавляются символьные значения.</param>
        /// <param name="characters">Символьные значения, которые добавляются в конец текста.</param>
        /// <returns>Новый текст, полученный путем добавления символьных значений в конец исходного текста.</returns>
        static string AppendCharacters(string text, params char[] characters)
        {
            for (int i = 0; i < characters.Length; i++)
                text += characters[i];

            return text;
        }

        static void Main(string[] args)
        {
            string text = "Royal flush is the strongest combination in";

            Console.WriteLine($"Введённый текст: {text}");

            string newText = AppendCharacters(text, ' ', 'p', 'o', 'k', 'e', 'r');

            Console.WriteLine($"Введённые символы: ' ', 'p', 'o', 'k', 'e', 'r', '.'");
            Console.WriteLine($"Строка с добавленными символами: {newText}");

            Console.WriteLine();
        }
    }
}
