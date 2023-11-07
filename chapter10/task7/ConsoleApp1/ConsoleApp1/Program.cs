using Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Наследование классов";


            BaseClass baseObj = new BaseClass();
            baseObj.stringValue = "Base Class String";
            BaseClass baseCopy = baseObj.CreateCopy();

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.stringValue = "Derived Class String";
            derivedObj.charValue = 'A';
            DerivedClass derivedCopy = (DerivedClass)derivedObj.CreateCopy();

            Console.WriteLine("Base Class String: " + baseCopy.stringValue);
            Console.WriteLine("Derived Class String: " + derivedCopy.stringValue);
            Console.WriteLine("Derived Class Char: " + derivedCopy.charValue);


            Console.WriteLine();
        }
    }
}
