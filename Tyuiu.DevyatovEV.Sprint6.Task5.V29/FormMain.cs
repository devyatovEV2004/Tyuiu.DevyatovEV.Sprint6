using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task5.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        private DataService ds_DEV;

        private double[] allValues_DEV = Array.Empty<double>();
        private double[] filteredValues_DEV = Array.Empty<double>();

        private string textPath_DEV;
        private string imagePath_DEV;

        public FormMain()
        {
            InitializeComponent();

            ds_DEV = new DataService();

            string baseDir = @"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\img";

            if (!Directory.Exists(baseDir))
                Directory.CreateDirectory(baseDir);

            textPath_DEV = Path.Combine(baseDir, "Output_Task5_DEV.txt");
            imagePath_DEV = Path.Combine(baseDir, "Chart_Task5_DEV.png");
        }

        // ========================= Выполнить ===============================
        private void buttonExecute_DEV_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath =
                    @"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\Sprint6Task5\InPutFileTask5V29.txt";

                allValues_DEV = ds_DEV.LoadFromDataFile(filePath);
                filteredValues_DEV = allValues_DEV.Where(v => v >= 10).ToArray();

                dataGridViewValues_DEV.Rows.Clear();
                dataGridViewValues_DEV.Columns.Clear();

                dataGridViewValues_DEV.Columns.Add("colAll", "Все значения");
                dataGridViewValues_DEV.Columns.Add("colFiltered", ">= 10");

                int rows = Math.Max(allValues_DEV.Length, filteredValues_DEV.Length);

                for (int i = 0; i < rows; i++)
                {
                    string a = (i < allValues_DEV.Length) ? allValues_DEV[i].ToString("0.###") : "";
                    string f = (i < filteredValues_DEV.Length) ? filteredValues_DEV[i].ToString("0.###") : "";

                    dataGridViewValues_DEV.Rows.Add(a, f);
                }

                pictureBoxChart_DEV.Refresh();

                File.WriteAllText(textPath_DEV, GenerateText_DEV(), Encoding.UTF8);

                using (Bitmap bmp = new Bitmap(pictureBoxChart_DEV.Width, pictureBoxChart_DEV.Height))
                {
                    pictureBoxChart_DEV.DrawToBitmap(bmp, pictureBoxChart_DEV.ClientRectangle);
                    bmp.Save(imagePath_DEV, System.Drawing.Imaging.ImageFormat.Png);
                }

                MessageBox.Show("Успешно завершено!\nФайлы сохранены.",
                    "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateText_DEV()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ВСЕ ЗНАЧЕНИЯ:");
            foreach (var v in allValues_DEV)
                sb.AppendLine(v.ToString("0.###"));

            sb.AppendLine("\nЗНАЧЕНИЯ >= 10:");
            foreach (var v in filteredValues_DEV)
                sb.AppendLine(v.ToString("0.###"));

            return sb.ToString();
        }

        // ========================= Рисование графика ===============================
        private void pictureBoxChart_DEV_Paint(object sender, PaintEventArgs e)
        {
            if (filteredValues_DEV.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int margin = 40;
            int width = pictureBoxChart_DEV.Width - 2 * margin;
            int height = pictureBoxChart_DEV.Height - 2 * margin;

            Pen axis = new Pen(Color.Black, 2);

            g.DrawLine(axis, margin, margin, margin, margin + height);
            g.DrawLine(axis, margin, margin + height, margin + width, margin + height);

            Font font = new Font("Arial", 9);

            double maxVal = filteredValues_DEV.Max();
            if (maxVal == 0) maxVal = 1;

            int barW = Math.Min(40, width / filteredValues_DEV.Length - 5);

            for (int i = 0; i < filteredValues_DEV.Length; i++)
            {
                double val = filteredValues_DEV[i];
                int barH = (int)(val / maxVal * (height - 20));

                int x = margin + 10 + i * (barW + 10);
                int y = margin + height - barH;

                g.FillRectangle(Brushes.LightSkyBlue, x, y, barW, barH);
                g.DrawRectangle(Pens.DarkBlue, x, y, barW, barH);

                g.DrawString(val.ToString("0.###"), font, Brushes.Black, x, y - 18);
                g.DrawString((i + 1).ToString(), font, Brushes.Black, x + barW / 2 - 6, margin + height + 2);
            }
        }

        // ========================= Открыть ===============================
        private void buttonOpen_DEV_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textPath_DEV) || !File.Exists(imagePath_DEV))
            {
                MessageBox.Show("Сначала выполните обработку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"Текстовый файл:\n{textPath_DEV}\n\nГрафик:\n{imagePath_DEV}",
                "Файлы сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ========================= Справка ===============================
        private void buttonInfo_DEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6\nТаск 5\nВариант 29\nВыполнил: Девятов Е.В.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
