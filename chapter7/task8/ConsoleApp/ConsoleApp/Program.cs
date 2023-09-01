using System;

namespace ConsoleApp
{
    class TextEditor
    {
        private string _text;

        public TextEditor(string text) 
        { 
            _text = text;
        }

        public void InsertSubstring(string substring, int index)
        {
            CheckIndex(index);

            _text = _text.Insert(index, substring);
        }

        public void CheckIndex(int index)
        {
            if (index < 0 || index >= _text.Length)
            {
                Console.WriteLine("Ошибка: введённый индекс не корректен!\n");
                Environment.Exit(0);
            }
        }

        public override string ToString()
        {
            return _text;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вставка подстроки в строку по индексу";


            string text = "Learn English using our high-quality resources to quickly improve your English.";
            var textEditor = new TextEditor(text);

            Console.WriteLine($"Исходный текст:\n{textEditor}\n");

            string substring = " online";
            int index = 13;
            textEditor.InsertSubstring(substring, index);

            Console.WriteLine($"Текст после вставки '{substring}' по индексу {index}:\n{textEditor}");


            Console.WriteLine();
        }
    }
}
