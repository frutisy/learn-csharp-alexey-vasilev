using System;
using System.Linq;

namespace ConsoleApp1
{
    class ArraySum
    {
        private int[] _array;

        public int Sum { get { return _array.Sum(); } }

        public ArraySum(int[] array)
        {
            _array = array;
        }
    }
}
