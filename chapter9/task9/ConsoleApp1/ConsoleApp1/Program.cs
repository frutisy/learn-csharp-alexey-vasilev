﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс с двумерным массив и индексаторами";


            int[,] array = 
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            var obj = new Array2D(array);

            // Используем двумерный индексатор для чтения и записи значений.
            Console.WriteLine($"Значение элемента в строке 2, столбце 3: {obj[1, 2]}");
            obj[1, 2] = 99;
            Console.WriteLine($"Значение элемента в строке 2, столбце 3 после изменения: {obj[1, 2]}");

            // Используем индексатор для поиска максимального элемента в строке.
            Console.WriteLine($"Максимальный элемент в строке 1: {obj[0]}");

            // Используем двумерный индексатор для чтения и записи значений.
            Console.WriteLine($"Значение элемента в строке 3, столбце 2: {obj[2, 1]}");
            obj[2, 1] = 100;
            Console.WriteLine($"Значение элемента в строке 3, столбце 2 после изменения: {obj[2, 1]}");

            // Используем индексатор для поиска максимального элемента в строке.
            Console.WriteLine($"Максимальный элемент в строке 2: {obj[1]}");


            Console.WriteLine();
        }
    }
}
