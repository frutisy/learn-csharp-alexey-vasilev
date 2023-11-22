namespace Classes
{
    class DerivedClass : BaseClass
    {
        private string _additionalTextField;

        public override string TextProperty 
        {
            get { return $"{textField} + {_additionalTextField}"; }
            set
            {

                if (value.Contains(" "))
                {
                    int spaceIndex = value.IndexOf(' ');
                    textField = value.Substring(0, spaceIndex);
                    _additionalTextField = value.Substring(spaceIndex + 1);
                }
                else
                {
                    textField = value;
                    _additionalTextField = string.Empty;
                }
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {textField}, {_additionalTextField}";
        }
    }
}
