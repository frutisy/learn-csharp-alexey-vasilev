using System;

namespace Classes
{
    class DerivedClass : BaseClass
    {
        public char[] symbols;

        public DerivedClass(int[] arrayOfNumbers, char[] arrayOfSymbols) : base(arrayOfNumbers)
        {
            symbols = arrayOfSymbols;
        }

        public new string ToString()
        {
            return base.ToString() + "\n" + string.Join(" ", symbols);
        }
    }
}
