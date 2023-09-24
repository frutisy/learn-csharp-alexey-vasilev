using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс для работы с восьмеричными числами";


            var obj = new OctalNumber();

            obj.IntegerValue = -1;
            obj.IntegerValue = 52;

            Console.WriteLine($"Для целочисленного значения {52} восьмеричный код будет равен {obj.OctalValue}");


            Console.WriteLine();
        }
    }
}
