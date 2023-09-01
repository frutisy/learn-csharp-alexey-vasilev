using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Проверка на соответствие критериям задачи";

            string taskCriterion = "Критерии задачи:\n" +
                "- при делении введённого числа на 5 в остатке получается 2,\n" +
                "- а при делении на 7 в остатке получается 1.";

            Console.WriteLine(taskCriterion);

            int number;
            bool isSatisfactionOfCriteria;

            Console.Write("Введите целое число: ");
            number = Int32.Parse(Console.ReadLine());

            isSatisfactionOfCriteria = (number % 5 == 2) & (number % 7 == 1)?true:false;

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
