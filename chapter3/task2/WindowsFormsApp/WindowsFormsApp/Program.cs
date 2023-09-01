using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 0;
            var secondNumber = 0;

            var msg = "Вы ввели не целое число!";
            var title = "Ошибка";
            MessageBoxIcon icon = MessageBoxIcon.Error;

            // Обработка исключения при неверном вводе типов чисел.
            try
            {
                firstNumber = int.Parse(Interaction.InputBox(
                    "Введите первое целое число",
                    "Ввод первого числа"));

                secondNumber = int.Parse(Interaction.InputBox(
                    "Введите второе целое число",
                    "Ввод второго числа"));
            }
            catch (FormatException)
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
                Environment.Exit(0);
            }

            // Определяет, какое из чисел больше.
            if (firstNumber > secondNumber)
            {
                msg = $"{firstNumber} > {secondNumber}";
                title = "Первое число больше";
                icon = MessageBoxIcon.Information;
            }
            else if (firstNumber < secondNumber)
            {
                msg = $"{firstNumber} < {secondNumber}";
                title = "Второе число больше";
                icon = MessageBoxIcon.Information;
            }
            else
            {
                msg = $"{firstNumber} = {secondNumber}";
                title = "Числа равны";
                icon = MessageBoxIcon.Information;
            }

            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
        }
    }
}
