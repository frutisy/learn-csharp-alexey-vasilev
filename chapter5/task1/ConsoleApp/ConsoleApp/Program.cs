using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Вычисляет двойной факториал с использованием рекурсии.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int DoubleFactorialWithRecursion(int n)
        { 
            if (n == 1 && n % 2 == 1) 
                return 1;
            
            if (n == 2 && n % 2 == 0)
                return 2;

            return n * DoubleFactorialWithRecursion(n - 2);
        }

        /// <summary>
        /// Вычисляет двойной факториал с использованием цикла for.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int DoubleFactorialWithLoop(int n)
        {
            int result = 1;

            if (n % 2 == 1)
            {
                for (int i = 1; i <= (n / 2); i++)
                    result *= i * 2 + 1;
            }
            else
            {
                for (int i = 1; i <= (n / 2); i++)
                    result *= i * 2;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int n;


            Console.WriteLine("Вычисление двойного факториала с использованием рекурсии:");

            n = 5;
            Console.WriteLine($"{n}!! = {DoubleFactorialWithRecursion(n)}");

            n = 6;
            Console.WriteLine($"{n}!! = {DoubleFactorialWithRecursion(n)}");

            Console.WriteLine();


            Console.WriteLine("Вычисление двойного факториала с использованием цикла for:");

            n = 5;
            Console.WriteLine($"{n}!! = {DoubleFactorialWithLoop(n)}");

            n = 6;
            Console.WriteLine($"{n}!! = {DoubleFactorialWithLoop(n)}");

            Console.WriteLine();
        }
    }
}
