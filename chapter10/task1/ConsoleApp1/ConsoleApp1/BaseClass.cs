using System;

namespace ConsoleApp1
{
    class BaseClass
    {
        protected string value;

        public BaseClass(string value)
        {
            this.value = value;
        }

        public override string ToString() 
        { 
            return $"Класс: {this.GetType()}\nТекстовое поле: {value}";
        }
    }

    class InheritedClass : BaseClass
    {
        protected string data;

        public InheritedClass(string data) : base(String.Empty)
        {
            this.data = data;
        }

        public InheritedClass(string value, string data) : base(value)
        {
            this.data = data;
        }

        public override string ToString() 
        { 
            if (value == String.Empty)
            {
                return $"Класс: {this.GetType()}\nТекстовое поле: {data}";
            }
            else
            {
                return $"Класс: {this.GetType()}\nПервое текстовое поле: {value}\nВторое текстовое поле: {data}";
            }
        }
    }
}
