namespace Classes
{
    class DerivedClass : BaseClass
    {
        public char charValue;
        
        public override BaseClass CreateCopy()
        {
            DerivedClass copy = new DerivedClass();
            copy.stringValue = stringValue;
            copy.charValue = charValue;
            return copy;
        }
    }
}
