using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Символьный диапазон";

            var rangePrinter = new CharacterRangePrinter();

            rangePrinter.SetRange('A', 'Z');

            rangePrinter.PrintCharactersInRange();

            Console.WriteLine();
        }
    }

    class CharacterRangePrinter
    {
        private char _startCharacter;
        private char _endCharacter;

        public void SetRange(char startCharacter, char endCharacter)
        {
            _startCharacter = startCharacter;
            _endCharacter = endCharacter;
        }

        public void PrintCharactersInRange()
        {
            Console.WriteLine($"Символы от {_startCharacter} до {_endCharacter} (включительно):");

            for (char i = _startCharacter; i <= _endCharacter; i++)
                Console.Write($"{i} ");

            Console.WriteLine();
        }
    }
}
