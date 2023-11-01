namespace Classes
{
    class DerivedClass1 : BaseClass
    {
        public string stringValue;

        public DerivedClass1(char symbol, string text) : base(symbol)
        {
            stringValue = text;
        }

        public DerivedClass1(DerivedClass1 other) : base(other)
        {
            stringValue = other.stringValue;
        }
    }
}
