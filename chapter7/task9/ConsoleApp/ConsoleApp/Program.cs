using System;

namespace ConsoleApp
{
    class StringSplitter
    {
        private string _text;
        private char _breakdownSymbol;

        public StringSplitter(string text, char symbol)
        {
            _text = text;
            _breakdownSymbol = symbol;
        }

        public string[] GetSubstrings()
        {
            return _text.Split(_breakdownSymbol);
        }

        public override string ToString() 
        {
            return $"Текстовое поле: {_text}" +
                   $"\nСимвольное поле: {_breakdownSymbol}\n" +
                   $"Подстроки: {string.Join(", ", GetSubstrings())}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Разбиение текста на подстроки по заданному символу";


            string text = "Music_is_a_moral_law.";
            char breakdownSymbol = '_';
            var stringSplitter = new StringSplitter(text, breakdownSymbol);

            Console.WriteLine("Информация о разделении строк:\n" + stringSplitter);


            Console.WriteLine();
        }
    }
}
