using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Проверка попадания числа в диапазон";

            int number;
            bool isNumberInRangeOf5to10;

            Console.Write("Введите целое число: ");
            number = Int32.Parse(Console.ReadLine());

            isNumberInRangeOf5to10 = (number == 5) | (number == 6) | (number == 7) | 
                                     (number == 8) | (number == 9) | (number == 10) ? true : false;

            if (isNumberInRangeOf5to10)
            {
                Console.WriteLine($"Число {number} входит в диапазон [5; 10]");
            }
            else
            {
                Console.WriteLine($"Число {number} не входит в диапазон [5; 10]");
            }
        }
    }
}
