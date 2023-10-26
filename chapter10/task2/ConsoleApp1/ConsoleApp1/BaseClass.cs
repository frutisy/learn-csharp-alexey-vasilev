using System;

namespace ConsoleApp1
{
    class BaseClass
    {
        protected string text;

        public BaseClass(string text)
        {
            this.text = text;
        }

        public int Length
        {
            get
            {
                return text.Length;
            }
        }

        public char this[int index]
        {
            get
            {
                if (index < 0 || index >= text.Length)
                {
                    throw new IndexOutOfRangeException("Индекс находился вне диапазона!");
                }
                else
                {
                    return text[index];
                }
            }
        }

        public void SetText()
        {
            text = string.Empty;
        }

        public void SetText(string newText)
        {
            text = newText;
        }
    }

    class InheritedClass : BaseClass
    {
        public int number;
        
        public InheritedClass(string text, int value) : base(text)
        {
            number = value;
        }

        public new void SetText() 
        {
            base.SetText(); 
            number = 0;
        }

        public void SetText(string newText)
        {
            base.SetText(newText);
        }

        public void SetText(int value)
        {
            number = value; 
        }

        public void SetText(string newText, int value)
        {
            SetText(newText);
            number = value;
        }
    }
}
