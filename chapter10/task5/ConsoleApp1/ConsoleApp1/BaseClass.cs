namespace Classes
{
    class BaseClass
    {
        public char charValue;

        public BaseClass(char symbol)
        {
            charValue = symbol;
        }

        public BaseClass(BaseClass other)
        {
            charValue = other.charValue;
        }
    }
}
