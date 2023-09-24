using System;

namespace ConsoleApp1
{
    class OddNumberGenerator
    {
        private static int _currentNumber = 0;

        public static int CurrentValue
        {
            get
            {
                _currentNumber += 2;
                return _currentNumber - 1;        
            }

            set
            {
                if (value >= 1)
                {
                    _currentNumber = value * 2;
                }
                else
                {
                   Console.WriteLine("Значение должно быть больше нуля.");
                 }
            }
        }
    }
}
