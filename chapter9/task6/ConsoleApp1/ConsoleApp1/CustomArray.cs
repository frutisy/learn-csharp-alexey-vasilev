using System;

namespace ConsoleApp1
{
    class CustomArray
    {
        private int[] _array;
        private int _startIndex; 

        public CustomArray(int size, int startIndex)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размер массива должен быть положительным числом.");
            }

            _array = new int[size];
            _startIndex = startIndex;
        }

        public int this[int index]
        {
            get
            {
                if (_IsValidIndex(index))
                {
                    return _array[index - _startIndex];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс находится за пределами допустимого диапазона.");
                }
            }

            set
            {
                if (_IsValidIndex(index))
                {
                    _array[index - _startIndex] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс находится за пределами допустимого диапазона.");
                }
            }
        }

        private bool _IsValidIndex(int index)
        {
            return index >= _startIndex && index < _startIndex + _array.Length;
        }
    }
}
