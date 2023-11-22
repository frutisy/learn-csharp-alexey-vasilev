using Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Классы для обработки текста";


            BaseClass baseObj = new BaseClass();
            baseObj.TextProperty = "BaseText";
            Console.WriteLine(baseObj.ToString());

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.TextProperty = "BaseText DerivedText";
            Console.WriteLine(derivedObj.ToString());


            Console.WriteLine();
        }
    }
}
