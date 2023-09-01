using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, age;

            name = Interaction.InputBox(
                "Введите имя: ",
                "Ввод имени");

            age = Interaction.InputBox(
                "Введите возраст: ",
                "Ввод возраста");

            MessageBox.Show(
                $"Вас зовут {name} и вам {age} лет",
                "Информация о пользователе",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }
    }
}
