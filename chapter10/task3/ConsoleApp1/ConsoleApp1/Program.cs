using System;
using Classes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Переопределение метода ToString() у базового и производного классов";


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            var inheritedInstance = new DerivedClass(numbers, symbols);

            Console.WriteLine($"Метод ToString() для производного экземпляра: \n{inheritedInstance.ToString()}");


            Console.WriteLine();
        }
    }
}
