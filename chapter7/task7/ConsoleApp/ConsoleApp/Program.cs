using System;
using System.Reflection.Emit;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Эмулятор метода Substring() с аргументами текста, начального индекса и длины подстроки";


            string text = "Everything is fine.";
            Console.WriteLine($"Текст: {text}");

            string substringOfText = Substring(text, 0, 5);
            Console.WriteLine($"Подстрока текста: {substringOfText}");


            Console.WriteLine();
        }

        static string Substring(string text, int startIndex, int length)
        {
            CheckStartIndex(text, startIndex);
            CheckLength(length);

            string substring = "";

            for (int i = startIndex; (i < startIndex + length) && (i < text.Length); i++)
            {
                substring += text[i];
            }

            return substring;
        }

        static void CheckStartIndex(string text, int startIndex)
        {
            if (startIndex < 0 || startIndex >= text.Length)
            {
                Console.WriteLine("Ошибка: начальный индекс вне диапазона!\n");
                Environment.Exit(0);
            }
        }

        static void CheckLength(int length)
        {
            if (length < 0)
            {
                Console.WriteLine("Ошибка: Количество символов не может быть отрицательным!\n");
                Environment.Exit(0);
            }
        }
    }
}
