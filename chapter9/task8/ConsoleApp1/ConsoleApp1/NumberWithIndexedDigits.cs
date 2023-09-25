using System;

namespace ConsoleApp1
{
    class NumberWithIndexedDigits
    {
        private int _number;

        public NumberWithIndexedDigits(int number)         
        {
            if (_number < 0)
            {
                throw new ArgumentException("Число должно быть неотрицательным.");
            }

            _number = number;
        }
        public int Number { get { return _number; } }

        public int this[int index]
        {
            set
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Индекс должен быть неотрицательным");

                int digit = value % 10;
                _number = _SetDigit(index, digit);
            }
        }

        private int _SetDigit(int index, int digit)
        {
            int temp = _number;
            int[] digits = new int[10];
            for (int i = 0; i < 10; i++)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }

            digits[index] = digit;
            int result = 0;
            for (int i = 9; i >= 0; i--)
            {
                result = result * 10 + digits[i];
            }

            return result;
        }
    }
}
