using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Проверка деления введённого числа на 3";

            int number;
            bool isDivisibleBy3; 

            Console.Write("Введите целое число: ");
            number = Int32.Parse(Console.ReadLine());

            isDivisibleBy3 = (number % 3 == 0)?true:false;

            if (isDivisibleBy3)
            {
                Console.WriteLine($"Число {number} делится на 3");
            }
            else
            {
                Console.WriteLine($"Число {number} не делится на 3");
            }
        }
    }
}
