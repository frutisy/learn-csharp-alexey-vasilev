namespace Classes
{
    class DerivedClass : BaseClass
    {
        protected char[] charArray;

        public DerivedClass(int size) : base(size)
        {
            charArray = new char[size];
        }

        public char this[char index]
        {
            get { return charArray[index]; }
            set { charArray[index] = value; }
        }

        public new int[] ArraySizes
        {
            get { return new int[] { intArray.Length, charArray.Length }; }
        }
    }
}
