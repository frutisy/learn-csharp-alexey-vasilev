using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Проверка на соответствие критериям задачи";

            string taskCriterion = "Критерии задачи: введённое число на 4 и при этом оно не меньше 10";

            Console.WriteLine(taskCriterion);

            int number;
            bool isSatisfactionOfCriteria;

            Console.Write("Введите целое число: ");
            number = Int32.Parse(Console.ReadLine());

            isSatisfactionOfCriteria = (number % 4 == 0) & (number >= 10) ? true : false;

            if (isSatisfactionOfCriteria)
            {
                Console.WriteLine($"Число {number} соответсвует критериям");
            }
            else
            {
                Console.WriteLine($"Число {number} не соответствует критериям");
            }
        }
    }
}
