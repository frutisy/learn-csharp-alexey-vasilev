using System;

namespace ConsoleApp
{
    class SymbolRangeLimited
    {
        private char _symbol;

        public char Symbol
        {
            get
            {
                return _symbol;
            }

            set
            {
                if (value >= 'A' && value <= 'Z')
                {
                    _symbol = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: значение свойства должно быть символом от 'А' до 'z' включительно.");
                }
            }
        }
    }
}
