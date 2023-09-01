using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Вычисление третьего бита справа";

        int number;
        int thirdBit;

        Console.Write("Введите целое число: ");
        number = Int32.Parse(Console.ReadLine());

        thirdBit = (number >> 2) & 1;

        Console.WriteLine($"Третий бит справа: {thirdBit}");
    }
}
