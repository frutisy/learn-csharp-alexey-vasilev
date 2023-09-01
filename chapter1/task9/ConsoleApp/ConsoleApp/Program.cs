using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Число-1, число, число+1";

            int smallerNumber, number, greaterNumber;

            Console.Write("Введите число: ");
            number = Int32.Parse(Console.ReadLine());

            smallerNumber = number - 1;
            greaterNumber = number + 1;

            Console.WriteLine($"Число, на единицу меньше - {smallerNumber}");
            Console.WriteLine($"Число {number}");
            Console.WriteLine($"Число, на единицу больше - {greaterNumber}");
        }
    }
}
