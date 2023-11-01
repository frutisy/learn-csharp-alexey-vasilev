using System;
using Classes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "";


            var obj1 = new DerivedClass2('A', "Hello", 52);
            var obj2 = new DerivedClass2(obj1);

            Console.WriteLine("--- Оригинал ---");
            Console.WriteLine($"charValue: {obj1.charValue}");
            Console.WriteLine($"stringValue: {obj1.stringValue}");
            Console.WriteLine($"intValue: {obj1.intValue}");

            Console.WriteLine();

            Console.WriteLine("--- Копия ---");
            Console.WriteLine($"charValue: {obj2.charValue}");
            Console.WriteLine($"stringValue: {obj2.stringValue}");
            Console.WriteLine($"intValue: {obj2.intValue}");


            Console.WriteLine();
        }
    }
}
