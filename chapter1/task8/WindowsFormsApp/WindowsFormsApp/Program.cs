using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, sum;

            number1 = Int32.Parse(Interaction.InputBox(
                "Введите первое число",
                "Ввод первого числа"));

            number2 = Int32.Parse(Interaction.InputBox(
                "Введите второе число",
                "Ввод второго числа"));

            sum = number1 + number2;

            MessageBox.Show(
                $"Сумма {number1} и {number2} равна {sum}",
                "Сумма двух чисел",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
