using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Последовательность Фибоначчи";

            Console.Write("Введите количество чисел в последовательности: ");
            var n = int.Parse(Console.ReadLine());

            var current = 1;
            var next = 1;
            var sum = 0;
            var i = 0;

            Console.Write($"{current} {next} ");

            while (i <= n - 2) 
            {
                sum = current + next;
                
                Console.Write(sum + " ");
                
                current = next;
                next = sum;
                i++;
            }
        }
    }
}
