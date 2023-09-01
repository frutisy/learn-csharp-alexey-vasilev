using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, sum, difference;

            number1 = Int32.Parse(Interaction.InputBox(
                "Введите первое число",
                "Ввод первого числа"));

            number2 = Int32.Parse(Interaction.InputBox(
                "Введите второе число",
                "Ввод второго числа"));

            sum = number1 + number2;
            difference = number1 - number2;

            MessageBox.Show(
                $"Сумма {number1} и {number2} равна {sum}",
                "Сумма двух чисел",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            MessageBox.Show(
                $"Разность {number1} и {number2} равна {difference}",
                "Разность двух чисел",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
