using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task1.V21.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task1.V21
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
                int xStart = -5;
                int xStop = 5;

                var vals = calc.GetMassFunction(xStart, xStop);

                var sb = new StringBuilder();
                sb.AppendLine("***************************");
                sb.AppendLine("*    x    *    f(x)       *");
                sb.AppendLine("***************************");

                for (int i = 0; i < vals.Length; i++)
                {
                    sb.AppendLine($"*   {xStart + i,3}   *   {vals[i],7:F2}     *");
                }

                sb.AppendLine("***************************");
                textBoxResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 1 Sprint6, вариант 21. Девятов Егор Владимирович",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}