using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int currentYear = 2023;
            int birthday;

            age = Int32.Parse(Interaction.InputBox(
                "Введите ваш возраст",
                "Ввод возраста"));

            birthday = currentYear - age;

            MessageBox.Show(
                $"Год вашего рождения - {birthday}",
                "Год рождения пользователя",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }
    }
}
