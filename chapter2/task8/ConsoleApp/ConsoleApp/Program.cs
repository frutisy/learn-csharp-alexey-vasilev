using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Установка третьего бита в единицу";

        int number;
        int modifiedNumber;

        Console.Write("Введите целое число: ");
        number = Int32.Parse(Console.ReadLine());

        modifiedNumber = number | (1 << 2);

        Console.WriteLine($"Число с установленным третьим битом: {modifiedNumber}");
    }
}
