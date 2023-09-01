using System;

class Program
{
    static void Main()
    {
        Console.Title = "Сумма чисел по заданным критериям";

        var count = 0;

        try
        {
            Console.Write("Введите количество чисел для суммирования: ");
            count = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное значение.");
            Environment.Exit(0);
        }

        var sum = 0;
        var numbersFound = 0;
        var number = 1;

        while (numbersFound < count)
        {
            if (number % 5 == 2 || number % 3 == 1)
            {
                sum += number;
                Console.WriteLine($"Число: {number}");
                numbersFound++;
            }
            number++;
        }

        Console.WriteLine($"Сумма чисел: {sum}");
    }
}
