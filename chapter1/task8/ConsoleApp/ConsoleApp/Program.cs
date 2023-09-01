using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сумма двух чисел";

            int number1, number2, sum;

            Console.Write("Введите первое число: ");
            number1 = Int32.Parse(Console.ReadLine());
                
            Console.Write("Введите второе число: ");
            number2 = Int32.Parse(Console.ReadLine());  

            sum = number1 + number2;

            Console.WriteLine($"Сумма {number1} и {number2} равна {sum}");
        }
    }
}
