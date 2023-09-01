using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Преобразует массив символов в массив целых чисел, содержащий коды символов в Unicode.
        /// </summary>
        /// <param name="characters">Массив символов, который необходимо преобразовать.</param>
        /// <returns>Массив целых чисел, содержащий коды символов в Unicode.</returns>
        static int[] GetCharactersCodes(char[] characters)
        {
            int[] codes = new int[characters.Length];

            for (int i = 0; i < codes.Length; i++)
                codes[i] = (int)characters[i];

            return codes;
        }

        static void Main(string[] args)
        {
            char[] characters = new char[] { 'a', 'b', 'c', 'x', 'y', 'z' };
            int[] codes = GetCharactersCodes(characters);

            for (int i = 0; i < characters.Length; i++)
                Console.WriteLine($"Код символа '{characters[i]}' - {codes[i]}");

            Console.WriteLine();
        }
    }
}
