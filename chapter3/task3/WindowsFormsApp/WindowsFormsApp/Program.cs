using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 0.0;
            var sum = 0.0;
            var count = 1;

            var msg = "Вы ввели не целое число!";
            var title = "Ошибка";
            MessageBoxIcon icon = MessageBoxIcon.Error;

            do
            {
                // Обработка исключения при неверном вводе типов чисел.
                try
                {
                    number = double.Parse(Interaction.InputBox(
                        "Введите число (0 - для завершения)",
                        $"Ввод {count} числа"));
                }
                catch (FormatException)
                {
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
                    Environment.Exit(0);
                }
                      
                sum += number;
                count++;

            } while (number != 0);

            msg = $"Сумма введённых чисел равна {sum}";
            title = "Сумма введённых чисел";
            icon = MessageBoxIcon.Information;

            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
        }
    }
}
