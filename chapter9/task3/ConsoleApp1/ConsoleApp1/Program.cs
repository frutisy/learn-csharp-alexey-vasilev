using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс с целочисленным массивом и свойством для считывания суммы элементов";


            int[] array = { 1, 2, 3, 4, 5 };  

            var obj = new ArraySum(array);

            Console.WriteLine($"Сумма элементов массива равна {obj.Sum}");


            Console.WriteLine();
        }
    }
}
