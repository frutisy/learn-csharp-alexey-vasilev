using System;

namespace Classes
{
    class DerivedClass1 : BaseClass
    {
        protected int intValue;

        public DerivedClass1(string text, int number) : base(text)
        {
            intValue = number;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Класс: {this.GetType().Name}\nТекстовое поле: {stringValue}\nЦелочисленное поле: {intValue}");
        }
    }
}
