namespace Classes
{
    class BaseClass
    {
        protected string textField;

        public virtual string TextProperty
        {
            get { return textField; }
            set { textField = value; }
        }

        public virtual string ToString()
        {
            return $"{GetType().Name}: {textField}";
        }
    }
}
