using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Программа для формирования алфавитно отсортированного массива уникальных букв из текста";


            string text = "Creativity and psychosis often go hand in hand. Or, for that matter, genius and madness.";
            Console.WriteLine($"Текст: {text}");

            char[] uniqueLetters = GetUniqueLetters(text);
            Console.WriteLine($"Уникальные буквы в тексте: {string.Join(", ", uniqueLetters)}");


            Console.WriteLine();
        }

        static char[] GetUniqueLetters(string text)
        {
            string cleanedText = new string(text.Where(c => char.IsLetter(c)).ToArray());

            cleanedText = cleanedText.ToLower();

            char[] uniqueLetters = cleanedText.Distinct().OrderBy(c => c).ToArray();

            return uniqueLetters;
        }
    }
}
