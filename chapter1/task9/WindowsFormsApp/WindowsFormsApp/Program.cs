using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallerNumber, number, greaterNumber;

            number = Int32.Parse(Interaction.InputBox(
                "Введите число",
                "Ввод числа"));

            smallerNumber = number - 1;
            greaterNumber = number + 1;

            MessageBox.Show(
                $"Число, на единицу меньше - {smallerNumber}",
                "Меньшее число",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

            MessageBox.Show(
                $"Число - {number}",
                "Введённое число",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

            MessageBox.Show(
                $"Число, на единицу больше - {greaterNumber}",
                "Большее число",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }
    }
}
