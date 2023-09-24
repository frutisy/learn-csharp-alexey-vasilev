using System;

namespace ConsoleApp
{
    class CircularArray
    {
        private int[] _numbers;
        private int _currentIndex;

        public CircularArray(int size)
        {
            _numbers = new int[size];
            _currentIndex = 0;
        }

        public int PropertyValue
        {
            get
            {
                if (_numbers.Length == 0)
                {
                    throw new InvalidOperationException("Массив пуст.");
                }

                int value = _numbers[_currentIndex];
                _currentIndex = (_currentIndex + 1) % _numbers.Length;
                return value;
            }

            set
            {
                if (_numbers.Length == 0)
                {
                    throw new InvalidOperationException("Массив пуст.");
                }

                _numbers[_currentIndex] = value;
            }
        }
    }
}
