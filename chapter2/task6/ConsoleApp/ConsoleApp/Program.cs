using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Проверка второй цифры в восьмеричном представлении";

        int number;
        string octalNumber;
        string result;

        Console.Write("Введите целое число: ");
        number = Int32.Parse(Console.ReadLine());

        octalNumber = Convert.ToString(number, 8);
        Console.Write(octalNumber);

        result = octalNumber.Length >= 2 ? $"Вторая справа цифра в восьмеричном представлении: {octalNumber[octalNumber.Length - 2]}" : "В восьмеричном представлении числа нет второй справа цифры";
        Console.WriteLine(result);
    }
}
