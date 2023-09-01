using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Изменение порядка элементов символьного массива на обратный";

            char[] chars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

            Console.WriteLine("Символный массив в исходном состоянии:");

            for (int i = 0; i < chars.Length; i++)
                Console.Write($"{chars[i]} ");

            for (int i = 0; i < (int)(chars.Length / 2); i++)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = temp;
            }

            Console.WriteLine("\nСимвольный массив в обратном порядке:");

            for (int i = 0; i < chars.Length; i++)
                Console.Write($"{chars[i]} ");               

            Console.WriteLine();
        }
    }
}
