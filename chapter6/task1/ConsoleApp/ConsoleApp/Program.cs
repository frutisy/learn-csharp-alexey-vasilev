using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Символьный класс и коды";

            var symbolHandler = new SymbolHandler();

            symbolHandler.SetSymbol('W');
            symbolHandler.PrintSymbolAndCode();

            Console.WriteLine();
        }
    }

    class SymbolHandler
    {
        private char _symbol;

        public void SetSymbol(char symbol)
        {
            _symbol = symbol; 
        }

        public int GetSymbolCode()
        {
            return (int)_symbol;
        }

        public void PrintSymbolAndCode()
        {
            Console.WriteLine($"Символ: {_symbol}");
            Console.WriteLine($"Код символа: {GetSymbolCode()}");
        }
    }
}
