using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Установка четвертого бита в ноль";

        int number;
        int modifiedNumber;

        Console.Write("Введите целое число: ");
        number = Int32.Parse(Console.ReadLine());

        modifiedNumber = number & ~(1 << 3);

        Console.WriteLine($"Число с установленным нулевым четвертым битом: {modifiedNumber}");
    }
}
