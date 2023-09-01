using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Изменение порядка слов в тексте на обратный";

            string textValue = "Somebody once told me the world is gonna roll me";
            Console.WriteLine($"Строка до изменения порядка слов:\n{textValue}");

            Console.WriteLine();

            string reversedTextValue = Reversed(textValue);
            Console.WriteLine($"Строка после изменения порядка слов:\n{reversedTextValue}");

            Console.WriteLine();
        }
        
        static string Reversed(string textValue)
        {
            string[] words = textValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] reversedWords = new string[words.Length];

            for (int i = words.Length - 1, j = 0; i >= 0; i--, j++)
                reversedWords[j] = words[i];

            return string.Join(" ", reversedWords);
        }
    }
}
