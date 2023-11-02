using System;
using Classes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пример наследования";

            // Создание экземпляров для всех классов.
            var baseObj = new BaseClass("Hello");
            Console.WriteLine();

            var derivedObj1 = new DerivedClass1("Hi", 52);
            Console.WriteLine();

            var derivedObj2 = new DerivedClass2("Mersy", 'F');
            Console.WriteLine();

            Console.WriteLine("------------------------------\n");

            // Вывод информации для каждого объекта.
            baseObj.ShowInfo();
            Console.WriteLine();

            derivedObj1.ShowInfo();
            Console.WriteLine();

            derivedObj2.ShowInfo();
            Console.WriteLine();

            Console.WriteLine("------------------------------\n");

            // Ссылка на производный класс в объекте базового класса.
            BaseClass reference1 = derivedObj1;
            BaseClass reference2 = derivedObj2;

            reference1.ShowInfo();
            Console.WriteLine();

            reference2.ShowInfo();
            Console.WriteLine();


            Console.WriteLine();
        }
    }
}
