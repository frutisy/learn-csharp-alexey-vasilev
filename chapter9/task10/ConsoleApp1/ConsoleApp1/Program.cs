using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс с текстовым массивом и индексаторами";


            string[] arrayOfStrings = { "Привет", "Мир", "C#", "Программирование" };
            var textArray = new TextArray(arrayOfStrings);

            // Используем одномерный индексатор для чтения и записи элементов.
            Console.WriteLine("Исходный текстовый массив:");
            for (int i = 0; i < arrayOfStrings.Length; i++)
                Console.WriteLine($"textArray[{i}] = {textArray[i]}");
            
            // Запись в элемент массива с помощью одномерного индексатора.
            textArray[1] = "Вселенная";             
            Console.WriteLine("\nОбновленный текстовый массив:");
            for (int i = 0; i < arrayOfStrings.Length; i++)
                Console.WriteLine($"textArray[{i}] = {textArray[i]}");

            // Используем двумерный индексатор для чтения символов в элементах.
            Console.WriteLine("\nСимволы в текстовом массиве:");
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                for (int j = 0; j < textArray[i].Length; j++)
                    Console.WriteLine($"textArray[{i}, {j}] = {textArray[i, j]}");
            }


            Console.WriteLine();
        }
    }
}
