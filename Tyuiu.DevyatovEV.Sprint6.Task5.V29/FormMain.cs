using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task5.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        private DataService dataService;
        private double[] allValues = Array.Empty<double>();
        private double[] filteredValues = Array.Empty<double>();

        public FormMain()
        {
            InitializeComponent();
            dataService = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\Egor\source\repos\Tyuiu.DevyatovEV.Sprint6\Sprint6Task5\InPutFileTask5V29.txt";
                allValues = dataService.LoadFromDataFile(filePath);
                filteredValues = allValues.Where(v => v >= 10).ToArray();

                dataGridViewValues.Rows.Clear();
                dataGridViewValues.Columns.Clear();

                dataGridViewValues.Columns.Add("colAll", "Все значения");
                dataGridViewValues.Columns.Add("colFiltered", "≥ 10");

                int rowCount = Math.Max(allValues.Length, filteredValues.Length);

                for (int i = 0; i < rowCount; i++)
                {
                    string allVal = (i < allValues.Length) ? allValues[i].ToString("0.###") : "";
                    string filteredVal = (i < filteredValues.Length) ? filteredValues[i].ToString("0.###") : "";
                    dataGridViewValues.Rows.Add(allVal, filteredVal);
                }

                pictureBoxChart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (filteredValues.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int margin = 50;
            int width = pictureBoxChart.Width - 2 * margin;
            int height = pictureBoxChart.Height - 2 * margin;

            // Рисуем оси
            Pen axis = new Pen(Color.Black, 2);
            g.DrawLine(axis, margin, margin, margin, margin + height); // Y-axis
            g.DrawLine(axis, margin, margin + height, margin + width, margin + height); // X-axis

            // Подписи осей
            Font font = new Font("Arial", 10);
            g.DrawString("Номер значения", font, Brushes.Black, margin + width / 2 - 40, margin + height + 20);
            g.DrawString("Значения ≥ 10", font, Brushes.Black, 10, margin);

            // Находим максимальное значение для масштабирования
            double maxVal = filteredValues.Max();
            if (maxVal == 0) maxVal = 1;

            // Размер столбцов
            int barWidth = Math.Min(40, width / Math.Max(1, filteredValues.Length) - 5);

            // Рисуем столбцы
            for (int i = 0; i < filteredValues.Length; i++)
            {
                double val = filteredValues[i];
                int barHeight = (int)((val / maxVal) * (height - 20));

                int x = margin + 10 + i * (barWidth + 10);
                int y = margin + height - barHeight;

                // Градиент цвета
                int red = Math.Clamp(100 + i * 15, 0, 255);
                int green = Math.Clamp(150 - i * 10, 50, 200);
                int blue = Math.Clamp(200 - i * 20, 100, 255);
                Brush bar = new SolidBrush(Color.FromArgb(red, green, blue));

                g.FillRectangle(bar, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.DarkBlue, x, y, barWidth, barHeight);

                // Подпись значения над столбцом
                string label = val.ToString("0.###");
                SizeF size = g.MeasureString(label, font);
                if (y - size.Height - 5 > 0)
                    g.DrawString(label, font, Brushes.Black, x + barWidth / 2 - size.Width / 2, y - size.Height - 5);

                // Подпись номера под осью X
                g.DrawString((i + 1).ToString(), font, Brushes.Black, x + barWidth / 2 - 5, margin + height + 5);

                bar.Dispose();
            }

            axis.Dispose();
            font.Dispose();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Task 5 | Вариант 29\nВыполнил: Девятов Егор Владимирович\n" +
                "Программа загружает данные из файла InPutFileTask5V29.txt\n" +
                "Выводит все числа и числа ≥ 10, строит диаграмму.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}