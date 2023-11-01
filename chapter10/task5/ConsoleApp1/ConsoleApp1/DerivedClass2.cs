namespace Classes
{
    class DerivedClass2 : DerivedClass1
    {
        public int intValue;

        public DerivedClass2(char symbol, string text, int number) : base(symbol, text)
        {
            intValue = number;
        }

        public DerivedClass2(DerivedClass2 other) : base(other) 
        { 
            intValue = other.intValue;
        }
    }
}
