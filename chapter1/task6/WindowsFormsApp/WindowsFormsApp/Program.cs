using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int birthday;
            int currentYear = 2023;

            name = Interaction.InputBox(
                "Введите ваше имя",
                "Ввод имени");

            birthday = Int32.Parse(Interaction.InputBox(
                "Введите год вашего рождения",
                "Ввод года рождения"));

            int age = currentYear - birthday;
            string message = $"Вас зовут - {name}. Ваш возраст - {age.ToString()}";

            MessageBox.Show(
                 message,
                 "Информация об имени и возрасте пользователя",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.None);
        }
    }
}
