using System;

namespace Classes
{
    class BaseClass
    {
        protected string stringValue;

        public BaseClass(string text) 
        { 
            stringValue = text;
            ShowInfo();
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Класс: {this.GetType().Name}\nТекстовое поле: {stringValue}");
        }
    }
}
