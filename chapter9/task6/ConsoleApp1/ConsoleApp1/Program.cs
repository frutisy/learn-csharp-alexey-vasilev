using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс для работы с нестандартными индексами массива";


            var customArray = new CustomArray(5, 1);

            customArray[1] = 10;
            customArray[2] = 20;
            customArray[3] = 30;

            Console.WriteLine($"Элемент с индексом 1: {customArray[1]}");
            Console.WriteLine($"Элемент с индексом 2: {customArray[2]}");
            Console.WriteLine($"Элемент с индексом 3: {customArray[3]}");


            Console.WriteLine();
        }
    }
}
