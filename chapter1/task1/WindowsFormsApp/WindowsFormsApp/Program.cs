using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;

            firstName = Interaction.InputBox(
                "Введите имя",
                "Ввод имени");

            lastName = Interaction.InputBox(
                "Введите фамилию",
                "Ввод фамилии");

            string greeting = "Приятно познакомиться, " + firstName + " " + lastName + "!";
            MessageBox.Show(
                greeting,
                "Знакомство состоялось",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }
    }
}
