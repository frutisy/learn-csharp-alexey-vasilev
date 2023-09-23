using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс с символьным свойством";


            var obj = new SymbolRangeLimited();
            obj.Symbol = 'Z';
            Console.WriteLine($"Символ: {obj.Symbol}");

            obj.Symbol = '1';


            Console.WriteLine();
        }
    }
}
