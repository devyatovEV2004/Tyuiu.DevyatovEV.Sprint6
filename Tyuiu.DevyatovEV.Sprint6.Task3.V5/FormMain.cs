using System;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task3.V5.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int[,] matrix = {
                { 30, -20, 7, -8, 9 },
                { 32, 17, -14, -7, 33 },
                { 19, -19, -13, 14, -20 },
                { 11, 30, -1, 26, 6 },
                { 30, -15, -20, -5, 15 }
            };

            int[,] sorted = ds.Calculate(matrix);

            dataGridViewResult.ColumnCount = 5;
            dataGridViewResult.RowCount = 5;
            dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult.Columns[i].HeaderText = $"Столбец {i + 1}";
                for (int j = 0; j < 5; j++)
                    dataGridViewResult.Rows[i].Cells[j].Value = sorted[i, j];
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Task 3 | Вариант 5 | Девятов Егор Владимирович",
                            "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}