using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сравнение строк посимвольно с учётом разницы в кодах не более 1";

            string text1 = "abcd";
            Console.WriteLine($"Строка 1: {text1}");

            string text2 = "`ccc";
            Console.WriteLine($"Строка 2: {text2}");

            Console.WriteLine();

            if (CompareStrings(text1, text2))
                Console.WriteLine("Строки совпадают");
            else
                Console.WriteLine("Строки не совпадают");

            Console.WriteLine();
        }

        static bool CompareStrings(string value1, string value2)
        {
            if (value1.Length != value2.Length)
                return false;

            char[] characters1 = value1.ToCharArray();
            char[] characters2 = value2.ToCharArray();

            for (int i = 0; i < characters1.Length; i++)
            {
                if (Math.Abs((int)characters1[i] - (int)characters2[i]) > 1)
                    return false;
            }

            return true;
        }
    }
}
