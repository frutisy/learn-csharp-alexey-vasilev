using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Управление целочисленным значением с ограничением и проверкой";

            var container1 = new NumberContainer();
            Console.WriteLine($"Значение поля: {container1.GetValue()}");

            var container2 = new NumberContainer(-20);
            Console.WriteLine($"Значение поля: {container2.GetValue()}");

            var container3 = new NumberContainer(200);
            Console.WriteLine($"Значение поля: {container3.GetValue()}");

            Console.WriteLine();
        }
    }

    class NumberContainer
    {
        private int _value;

        public NumberContainer() 
        { 
            SetValue();
        }

        public NumberContainer(int value)
        {
            SetValue(value);
        }

        public void SetValue(int value = 0)
        {
            if(_CheckValue(value))
            {
                _value = 100;
            }
            else
            {
                _value = value;
            }
        }

        public int GetValue()
        {
            return _value;
        }

        private bool _CheckValue(int value)
        {
            return value > 100;
        }
    }
}
