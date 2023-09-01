using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс с символьным и целочисленным полем";

            var objectWithTwoArgs = new SymbolAndIntegerFieldsClass(12, 'Q');
            objectWithTwoArgs.PrintFields();

            var objectWithOneArg = new SymbolAndIntegerFieldsClass(65.48345);
            objectWithOneArg.PrintFields();
        }
    }

    class SymbolAndIntegerFieldsClass
    {
        private char _symbolField;
        private int _integerField;

        public SymbolAndIntegerFieldsClass(int integerValue, char symbolValue)
        {
            _symbolField = symbolValue;
            _integerField = integerValue;
        }

        public SymbolAndIntegerFieldsClass(double value)
        {
            _symbolField = (char)((int)value);         
            _integerField = (int)((Math.Round(value, 2) - (int)value) * 100);
        }

        public void PrintFields()
        {
            Console.WriteLine("--- Создан новый объект ---");
            Console.WriteLine($"Символьное поле: {_symbolField}");
            Console.WriteLine($"Целочисленное поле: {_integerField}");
            Console.WriteLine();
        }
    }
}
