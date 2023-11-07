namespace Classes
{
    class BaseClass
    {
        public string stringValue;

        public virtual BaseClass CreateCopy() 
        {
            BaseClass copy = new BaseClass();
            copy.stringValue = stringValue;
            return copy;
        }
    }
}
