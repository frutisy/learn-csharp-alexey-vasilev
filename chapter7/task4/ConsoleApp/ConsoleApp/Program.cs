using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сравнение текстовых строк по набору уникальных букв";

            string str1 = "aezakmi";
            Console.WriteLine($"Строка 1: {str1}");

            string str2 = "akkkkeeeezzzkmi";
            Console.WriteLine($"Строка 2: {str2}");

            bool areEqual = AreStringsEqualByDistinctLetters(str1, str2);
            Console.WriteLine(areEqual ? "Строки содержат одинаковые наборы букв" : "Строки содержат разные наборы букв");

            Console.WriteLine();
        }

        static bool AreStringsEqualByDistinctLetters(string str1, string str2) 
        {
            char[] setOfLetters1 = str1.Distinct().OrderBy(x => x).ToArray();
            char[] setOfLetters2 = str2.Distinct().OrderBy(x => x).ToArray();

            if (string.Join("", setOfLetters1) == string.Join("", setOfLetters2))
                return true;
            return false;
        }
    }
}
