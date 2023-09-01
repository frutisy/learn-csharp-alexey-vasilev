using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс для увеличивания значения счётчика";

            Counter.PrintAndIncrementCount();
            Counter.PrintAndIncrementCount();
            Counter.PrintAndIncrementCount();

            Console.WriteLine();
        }
    }

    class Counter
    {
        private static int _count = 0;

        public static void PrintAndIncrementCount()
        {
            Console.WriteLine($"Текущее значение счётчика равно {_count++}");
        }
    }
}
