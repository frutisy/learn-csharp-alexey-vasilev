using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Базовый и наследуемый классы с защищёнными текстовыми полями";


            var baseInstance = new BaseClass("Queen");
            Console.WriteLine(baseInstance);

            Console.WriteLine();

            var inheritedInstance1 = new InheritedClass("Nirvana");
            Console.WriteLine(inheritedInstance1);

            Console.WriteLine();

            var inheritedInstance2 = new InheritedClass("The", "Cranberries");
            Console.WriteLine(inheritedInstance2);


            Console.WriteLine();
        }
    }
}
