using System;
using System.Linq;

namespace ConsoleApp
{
    class ArrayInfo
    {
        private int[] _arrayOfNumbers;

        public ArrayInfo(int arraySize) 
        { 
            _arrayOfNumbers = new int[arraySize];
            _FillArrayWithRandomNumbers(arraySize);
        }

        private void _FillArrayWithRandomNumbers(int arraySize)
        {
            Random random = new Random();

            for (int i = 0; i < _arrayOfNumbers.Length; i++)
            {
                _arrayOfNumbers[i] = random.Next(1, 101);
            }
        }

        public override string ToString()
        {
            return $"Элементы массива: [{string.Join(", ", _arrayOfNumbers)}]\n" +
                   $"Количество элементов: {_arrayOfNumbers.Length}\n" +
                   $"Среднее значение: {(double)_arrayOfNumbers.Sum() / _arrayOfNumbers.Length}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пример работы с массивом";


            int arraySize = 10;
            var arrayInfo = new ArrayInfo(arraySize);

            Console.WriteLine("Информация о массиве:\n" + arrayInfo);


            Console.WriteLine();
        }
    }
}
