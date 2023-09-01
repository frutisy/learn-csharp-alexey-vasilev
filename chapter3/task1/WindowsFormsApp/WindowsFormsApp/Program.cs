using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            string msg = "Неправильный ввод значения";
            string title = "Ошибка";
            MessageBoxIcon icon = MessageBoxIcon.Error;

            try
            {
                number = Int32.Parse(Interaction.InputBox(
                    "Введите целое число: ",
                    "Ввод числа"));
            }
            catch
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
                Environment.Exit(0);
            }

            if ((number % 3 == 0) && (number % 7 == 0))
            {
                msg = $"Число {number} делится на 3 и на 7";
                title = "Условие выполнено";
                icon = MessageBoxIcon.Asterisk;
            }
            else
            {
                msg = $"Число {number} не делится на 3 и на 7";
                title = "Условие не выполнилось";
                icon = MessageBoxIcon.Error;
            }

            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
        }
    }
}
