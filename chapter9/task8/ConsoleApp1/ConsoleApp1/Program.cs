using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс для замены цифр в разрядах числа";


            int number = 12345;
            var obj = new NumberWithIndexedDigits(number);

            Console.WriteLine($"Число до изменений: {obj.Number}");

            obj[1] = 7;
            obj[2] = 8;

            Console.WriteLine($"Число после изменений: {obj.Number}");


            Console.WriteLine();
        }
    }
}
