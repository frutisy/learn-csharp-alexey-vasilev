using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число: ");
        var number = int.Parse(Console.ReadLine());

        var mask = 1 << 1;

        var toggledNumber = number ^ mask;

        Console.WriteLine($"Результат: {toggledNumber}");
    }
}
