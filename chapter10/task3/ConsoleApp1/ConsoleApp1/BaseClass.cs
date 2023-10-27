using System;

namespace Classes
{
    class BaseClass
    {
        public int[] numbers;

        public BaseClass(int[] arrayOfNumbers)
        {
            numbers = arrayOfNumbers;
        }

        public new string ToString()
        {
           return string.Join(" ", numbers);
        }
    }
}
