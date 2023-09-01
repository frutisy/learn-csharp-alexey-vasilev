using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Реализация класса для хранения символа и текста";

            var obj = new SymbolTextHolder();

            obj.AssignValue('A'); 
            obj.PrintValues();

            Console.WriteLine();

            obj.AssignValue("Hello"); 
            obj.PrintValues();

            Console.WriteLine();

            char[] charArray = { 'H', 'i' };
            obj.AssignValue(charArray); 
            obj.PrintValues();

            Console.WriteLine();

            charArray = new char[] { 'X' };
            obj.AssignValue(charArray); 
            obj.PrintValues();

            Console.WriteLine();
        }
    }

    class SymbolTextHolder
    {
        private char _symbol;
        private string _text;

        public void AssignValue(char symbol)
        {
            _symbol = symbol;
        }

        public void AssignValue(string text) 
        { 
            _text = text;   
        }

        public void AssignValue(char[] symbols)
        {
            if (symbols.Length == 1)
                _symbol = symbols[0];
            else
                _text = new string(symbols);
        }

        public void PrintValues()
        {
            Console.WriteLine($"Символьное значение: {_symbol}");
            Console.WriteLine($"Текстовое значение: {_text}");
        }
    }
}
