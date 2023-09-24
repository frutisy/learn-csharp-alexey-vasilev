using System;

namespace ConsoleApp1
{
    class OctalNumber
    {
        private int _integerValue;
        private string _octalValue;

        public int IntegerValue
        {
            set
            {
                if (value >= 0) 
                {
                    _integerValue = value;
                    _octalValue = Convert.ToString(value, 8);
                }
                else
                {
                    Console.WriteLine("Значение должно быть неотрицательным.");
                }
            }
        }

        public string OctalValue { get { return _octalValue; } }
    }
}
