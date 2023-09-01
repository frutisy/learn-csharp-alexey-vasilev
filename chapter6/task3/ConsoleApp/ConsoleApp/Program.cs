using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс с целочисленными полями";

            var integerObjectWithoutArgs = new IntegerFieldsClass();
            integerObjectWithoutArgs.PrintFields();

            var integerObjectWithArg = new IntegerFieldsClass(2);
            integerObjectWithArg.PrintFields();

            var integerObjectWithArgs = new IntegerFieldsClass(2, 4);
            integerObjectWithArgs.PrintFields();
        }
    }

    class IntegerFieldsClass
    {
        private int _field1;
        private int _field2;

        public IntegerFieldsClass() 
        {
            _field1 = 0;
            _field2 = 0;
        }

        public IntegerFieldsClass(int arg1)
        {
            _field1 = arg1;
            _field2 = 0;
        }

        public IntegerFieldsClass(int arg1, int arg2)
        {
            _field1 = arg1;
            _field2 = arg2;
        }

        public void PrintFields()
        {
            Console.WriteLine($"--- Создан новый объект ---");
            Console.WriteLine($"Первое поле: {_field1}");
            Console.WriteLine($"Второе поле: {_field2}");
            Console.WriteLine();
        }
    }
}
