using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс с массивом и циклическим свойством";


            var obj = new CircularArray(5);

            Console.WriteLine("Первые два значения:");

            obj.PropertyValue = 1;
            Console.WriteLine($"Значение свойства: {obj.PropertyValue}");

            obj.PropertyValue = 2;
            Console.WriteLine($"Значение свойства: {obj.PropertyValue}");

            Console.WriteLine("\nПоследние три значения:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Значение свойства: {obj.PropertyValue}");
            }

            Console.WriteLine("\nВсе значения:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Значение свойства: {obj.PropertyValue}");
            }


            Console.WriteLine();
        }
    }
}
