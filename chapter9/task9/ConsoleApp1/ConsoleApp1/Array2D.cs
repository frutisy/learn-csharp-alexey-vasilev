using System;

namespace ConsoleApp1
{
    class Array2D
    {
        int[,] _numberArray;

        public Array2D(int[,] numberArray)
        {
            _numberArray = numberArray;
        }

        public int this[int row]
        {
            get
            {
                if (row < 0 || row >= _numberArray.Length)
                {
                    throw new IndexOutOfRangeException("Недопустимый индекс строки!");
                }

                int max = _numberArray[row, 0];
                for (int col = 1; col < _numberArray.GetLength(1); col++)
                {
                    if (_numberArray[row, col] > max)
                    {
                        max = _numberArray[row, col];
                    }
                }
                return max;
            }
            set
            {
                if (row < 0 || row >= _numberArray.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Недопустимый индекс строки!");
                }
                else
                {
                    int maxColumn = 0;
                    int max = _numberArray[row, 0];
                    for (int col = 1; col < _numberArray.GetLength(1); col++)
                    {
                        if (_numberArray[row, col] > max)
                        {
                            max = _numberArray[row, col];
                            maxColumn = col;
                        }
                    }
                    _numberArray[row, maxColumn] = value;
                }
            }
        }

        public int this[int row, int column]
        {
            get
            {
                if (row < 0 || row >= _numberArray.Length || 
                    column < 0 || column >= _numberArray.GetLength(row - 1))
                {
                    throw new IndexOutOfRangeException("Недопустимый индекс строки или столбца!");
                }
                return _numberArray[row, column];

            }
            set
            {
                if (row < 0 || row >= _numberArray.Length || 
                    column < 0 || column >= _numberArray.GetLength(row - 1))
                {
                    throw new IndexOutOfRangeException("Недопустимый индекс строки или столбца!");
                }
                else
                {
                    _numberArray[row, column] = value;
                }
            }
        }
    }
}
