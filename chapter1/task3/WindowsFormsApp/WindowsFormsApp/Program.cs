using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weekday, month, date;

            weekday = Interaction.InputBox(
                "Введите день недели: ",
                "Ввод дня недели");

            month = Interaction.InputBox(
                "Введите название месяца: ",
                "Ввод названия месяца");

            date = Interaction.InputBox(
                "Введите номер дня в месяце: ",
                "Ввод номера дня в месяце");

            string fullDate = $"{weekday}, {date}, {month}";
            MessageBox.Show(
                fullDate,
                "Полная дата",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }
    }
}
