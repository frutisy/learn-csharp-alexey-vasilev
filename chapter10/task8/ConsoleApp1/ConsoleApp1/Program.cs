using Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Переопределение индекстаторов";

            var baseObject = new BaseClass { IntValue1 = 12345 };
            var derivedObject = new DerivedClass { IntValue1 = 9876, IntValue2 = 54321 };

            Console.WriteLine("Базовый Класс:");
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"Цифра на позиции {i}: {baseObject[i]}");

            Console.WriteLine("\nПроизводный Класс:");
            for (int fieldIndex = 0; fieldIndex < 2; fieldIndex++)
            {
                for (int digitPosition = 0; digitPosition < 5; digitPosition++)
                    Console.WriteLine($"Цифра на позиции {digitPosition} в Поле {fieldIndex}: {derivedObject[fieldIndex, digitPosition]}");
            }


            Console.WriteLine();
        }
    }
}
