using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вычисление cos(x), cosh(x) и sinh(x)";

            double x = 0.5;

            Console.WriteLine($"TrigonometricUtils.Cos({x}) = {TrigonometricUtils.Cos(x)}");
            Console.WriteLine($"TrigonometricUtils.Sinh({x}) = {TrigonometricUtils.Sinh(x)}");
            Console.WriteLine($"TrigonometricUtils.Cosh({x}) = {TrigonometricUtils.Cosh(x)}");

            Console.WriteLine();
        }
    }

    class TrigonometricUtils
    {
        private const int _ACCURACY = 10;

        private static long _Factorial(int n)
        {
            long factorial = 1;

            for (int i = 1; i <= n; i++)
                factorial *= i;

            return factorial;
        }

        public static double Cos(double x)
        {
            double result = 0;

            for (int i = 0; i < _ACCURACY; i++)
                result += Math.Pow(-1, i) * Math.Pow(x, 2 * i) / _Factorial(2 * i);

            return result;
        }

        public static double Sinh(double x)
        {
            double result = 0.0;

            for (int i = 0; i < _ACCURACY; i++)
                result += Math.Pow(x, 2 * i + 1) / _Factorial(2 * i + 1);

            return result;
        }

        public static double Cosh(double x)
        {
            double result = 0.0;

            for (int i = 0; i < _ACCURACY; i++)
                result += Math.Pow(x, 2 * i) / _Factorial(2 * i);

            return result;
        }
    }
}
