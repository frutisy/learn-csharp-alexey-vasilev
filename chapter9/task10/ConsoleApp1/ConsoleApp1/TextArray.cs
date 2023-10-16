using System;
using System.Data.Common;

namespace ConsoleApp1
{
    class TextArray
    {
        private string[] _textArray;

        public TextArray(string[] array)
        {
            _textArray = array;
        }

        public string this[int index] 
        { 
            get
            {
                return _textArray[index % _textArray.Length];
            }

            set
            {
                _textArray[index % _textArray.Length] = value;
            }
        }

        public char this[int row, int column]
        {
            get
            {
                string text = _textArray[row % _textArray.Length];
                column = column % text.Length;
                return text[column];
            }
        }
    }
}
