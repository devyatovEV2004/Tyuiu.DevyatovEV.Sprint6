using System;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task0.V23.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        private DataService calc = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int xVal = 3;
                double res = calc.Calculate(xVal);
                textBoxResult.Text = $"Результат при x = {xVal}: {res:F3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 0 Sprint6, вариант 23 выполнен студентом Девятов Егор Владимирович",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}