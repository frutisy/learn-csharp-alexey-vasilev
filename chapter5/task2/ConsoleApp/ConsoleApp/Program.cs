using System;

namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Вычисляет сумму квадратов натуральных чисел от 1 до n с использованием рекурсии.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SumOfSquaresWithRecursion(int n)
        {
            if (n == 1) return 1;

            return n * n + SumOfSquaresWithRecursion(n - 1);
        }

        /// <summary>
        /// Вычисляет сумму квадратов натуральных чисел от 1 до n с использованием цикла for.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SumOfSquaresWithLoop(int n)
        {
            int result = 0;

            for (int i = 1; i <= n; i++)
                result += i * i;

            return result;
        }

        /// <summary>
        /// Вычисляет сумму квадратов натуральных чисел от 1 до n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SumOfSquaresFormula(int n)
        {
            return (n * (n + 1) * (2 * n + 1)) / 6;
        }

        static void Main(string[] args)
        {
            int n = 5;

            Console.WriteLine($"Сумма квадратов натуральных чисел от 1 до {n} по формуле равна {SumOfSquaresFormula(n)}");
            Console.WriteLine($"Сумма квадратов натуральных чисел от 1 до {n} с использованием рекурсии равна {SumOfSquaresWithRecursion(n)}");
            Console.WriteLine($"Сумма квадратов натуральных чисел от 1 до {n} с использованием цикла for равна {SumOfSquaresWithLoop(n)}");
        }
    }
}
