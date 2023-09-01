using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Программа с классом для поиска минимального и максимального значений";

            var container1 = new MinMaxContainer();
            container1.SetValues(-20, 20);
            container1.PrintValues();

            Console.WriteLine();

            var container2 = new MinMaxContainer();
            container2.SetValues(40, -20);
            container2.PrintValues();

            Console.WriteLine();

            var container3 = new MinMaxContainer(-2, 21);
            container3.PrintValues();

            Console.WriteLine();
        }
    }

    class MinMaxContainer
    {
        private int _min = -1;
        private int _max = 1;

        public MinMaxContainer(int min = -1, int max = 1) 
        {
            SetValues(min, max);
        }

        public void SetValues(int min = -1, int max = 1)
        {
            if (_CheckValues(min, max))
            {
                _min = Math.Min(_min, min);
                _max = Math.Max(_max, max);
            }
            else 
            {
                Console.WriteLine($"Второй аргумент должен быть больше первого!");
            }
        }

        private bool _CheckValues(int min, int max)
        {
            if (max > min)
                return true;
            return false;
        }

        public void PrintValues()
        {
            Console.WriteLine($"Минимальное значение: {_min}");
            Console.WriteLine($"Максимальное значение: {_max}");
        }
    }
}
