using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вставка пробелов между символами";

            string textValue = "That's what chess is all about. Today you give your opponent a lesson, and tomorrow he gives you one.";
            Console.WriteLine($"Строка до вставки пробелов:\n{textValue}");

            Console.WriteLine();

            string newTextValue = InsertSpacesBetweenCharacters(textValue);
            Console.WriteLine($"Строка после вставки пробелов:\n{newTextValue}");

            Console.WriteLine();
        }

        static string InsertSpacesBetweenCharacters(string textValue)
        {
            string newTextValue = "";

            foreach (var symbol in textValue)
                newTextValue += symbol + " ";

            return newTextValue;
        }
    }
}
