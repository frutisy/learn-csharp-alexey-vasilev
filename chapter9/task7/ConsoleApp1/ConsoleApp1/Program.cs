using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс для представления десятичного числа в двоичное";


            int number = 52;
            var obj = new BinaryIndexer(number);

            Console.WriteLine($"Число {number} в двоичном представлении:");
            for (int i = 0; i < obj.BinaryNumberLength; i++)
            {
                Console.WriteLine($"Бит [{0}]: {obj[0]}");
            }


            Console.WriteLine();
        }
    }
}
