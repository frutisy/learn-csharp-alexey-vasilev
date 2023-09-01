using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Определение тысяч в введённом числе";

            int number;
            int numberOfThousands;

            Console.Write("Введите целое число: ");
            number = Int32.Parse(Console.ReadLine());

            numberOfThousands = number / 1000 % 10;

            Console.WriteLine($"Количество тысяч в числе {number} равно {numberOfThousands}");
        }
    }
}
