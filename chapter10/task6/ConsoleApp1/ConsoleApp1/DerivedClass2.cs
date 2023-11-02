using System;

namespace Classes
{
    class DerivedClass2 : BaseClass
    {
        protected char charValue;

        public DerivedClass2(string text, char symbol) : base(text)
        {
            charValue = symbol;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Класс: {this.GetType().Name}\nТекстовое поле: {stringValue}\nСимвольное поле: {charValue}");
        }
    }
}
