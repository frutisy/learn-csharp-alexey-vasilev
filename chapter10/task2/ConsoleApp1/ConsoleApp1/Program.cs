using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Базовый и производный классы с индексатором и методами";


            var inheritedInstance = new InheritedClass("Ode To My Family", 52);

            Console.WriteLine($"Длина текста: {inheritedInstance.Length}");
            Console.WriteLine($"Символ по индексу 7: {inheritedInstance[7]}");

            inheritedInstance.SetText("Новый текст");
            Console.WriteLine($"Длина нового текста: {inheritedInstance.Length}");

            inheritedInstance.SetText(99);
            Console.WriteLine($"Дополнительное поле: {inheritedInstance.number}");

            inheritedInstance.SetText("Еще один текст", 123);
            Console.WriteLine($"Длина нового текста: {inheritedInstance.Length}, Дополнительное поле: {inheritedInstance.number}");


            Console.WriteLine();
        }
    }
}
