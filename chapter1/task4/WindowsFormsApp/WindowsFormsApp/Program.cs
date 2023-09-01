using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month, numberOfDaysInMonth;

            month = Interaction.InputBox(
                "Введите название месяца",
                "Ввод названия месяца");

            numberOfDaysInMonth = Interaction.InputBox(
                "Введите количество дней в месяце",
                "Ввод количества дней в месяце");

            MessageBox.Show(
                $"В {month} {numberOfDaysInMonth} дней",
                "Информация о количестве дней в месяце",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }
    }
}
