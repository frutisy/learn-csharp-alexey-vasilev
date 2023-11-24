using Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Замещение свойств";


            // Создание экземпляра базового класса.
            var baseObj = new BaseClass(5);

            baseObj[1] = 1;
            baseObj[2] = 2;
            baseObj[3] = 3;

            Console.WriteLine("Работа с экземпляром базового класса:");
            for (int i = 0; i < baseObj.ArraySizes[0]; i++)
                Console.Write($"| {baseObj[i]} | ");

            Console.WriteLine("\n");

            // Создание экземпляра производного класса.
            var derivedObj = new DerivedClass(3);

            derivedObj[0] = 'A';
            derivedObj[1] = 'B';
            derivedObj[2] = 'C';

            Console.WriteLine("Работа с экземпляром производного класса:");
            for (int i = 0; i < derivedObj.ArraySizes[1]; i++)
                Console.WriteLine($"Индексу '{(char)i}' соответствует элемент массива '{derivedObj[i]}'");


            Console.WriteLine();
        }
    }
}
