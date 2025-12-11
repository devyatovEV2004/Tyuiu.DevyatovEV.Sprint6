using System;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task2.V12.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        DataService dataService = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int start = -5;
            int stop = 5;

            double[] values = dataService.GetMassFunction(start, stop);

            dataGridViewResult.Rows.Clear();
            dataGridViewResult.Columns.Clear();

            dataGridViewResult.Columns.Add("colX", "X");
            dataGridViewResult.Columns.Add("colF", "f(x)");

            for (int i = 0; i < values.Length; i++)
                dataGridViewResult.Rows.Add(start + i, values[i]);

            dataGridViewResult.Columns[0].Width = 60;
            dataGridViewResult.Columns[1].Width = 120;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Task 2 | Вариант 12 | Девятов Егор Владимирович",
                            "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}