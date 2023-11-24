namespace Classes
{
    class BaseClass
    {
        protected int[] intArray;

        public BaseClass(int size)
        {
            intArray = new int[size];
        }

        public int this[int index]
        {
            get { return intArray[index]; }
            set { intArray[index] = value; }
        }

        public int[] ArraySizes
        {
            get { return new int[] { intArray.Length }; }
        }
    }
}
