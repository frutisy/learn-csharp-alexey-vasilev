using System;

namespace ConsoleApp1
{
    class BinaryIndexer
    {
        private string _binaryNumber;
        private int _counter = 0;

        public BinaryIndexer(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Число должно быть неотрицательным.");
            }

            _binaryNumber = Convert.ToString(number, 2);
        }

        public int BinaryNumberLength { get { return _binaryNumber.Length; } }

        public string this[int index]
        {
            get
            {
                if (_counter == _binaryNumber.Length)
                {
                     _counter = 0; 
                }

                return _binaryNumber[_counter++].ToString();   
            }
        }
    }
}
