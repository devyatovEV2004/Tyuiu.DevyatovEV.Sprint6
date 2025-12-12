using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task7.V22
{
    public partial class FormMain : Form
    {
        private string selectedFile = "";

        public FormMain()
        {
            InitializeComponent();
        }

        // ╔══════════════════════════════════════╗
        // ║         ЗАГРУЗКА CSV ФАЙЛА          ║
        // ╚══════════════════════════════════════╝
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    Title = "Выберите CSV файл"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = ofd.FileName;

                    LoadMatrixToGrid(selectedFile);

                    labelFileInfo.Text = "Файл: " + Path.GetFileName(selectedFile);
                    buttonProcess.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке файла!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Загрузка CSV в DataGridView
        private void LoadMatrixToGrid(string path)
        {
            var lines = File.ReadAllLines(path);
            dataGridViewIn.Rows.Clear();
            dataGridViewIn.Columns.Clear();

            int cols = lines[0].Split(';').Length;

            for (int i = 0; i < cols; i++)
                dataGridViewIn.Columns.Add("col" + i, "Столбец " + (i + 1));

            foreach (var line in lines)
                dataGridViewIn.Rows.Add(line.Split(';'));
        }

        // ╔══════════════════════════════════════╗
        // ║        ОБРАБОТКА МАТРИЦЫ             ║
        // ╚══════════════════════════════════════╝
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (dataGridViewIn.Rows.Count == 0)
            {
                MessageBox.Show("Сначала загрузите файл!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewOut.Rows.Clear();
            dataGridViewOut.Columns.Clear();

            foreach (DataGridViewColumn col in dataGridViewIn.Columns)
                dataGridViewOut.Columns.Add(col.Name, col.HeaderText);

            // 6-й столбец = индекс 5
            int targetCol = 5;

            foreach (DataGridViewRow row in dataGridViewIn.Rows)
            {
                if (row.IsNewRow) continue;

                object[] newRow = new object[row.Cells.Count];

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    int value = int.Parse(row.Cells[i].Value.ToString());

                    if (i == targetCol && value > 0 && value % 2 == 0)
                        newRow[i] = 111;
                    else
                        newRow[i] = value;
                }

                dataGridViewOut.Rows.Add(newRow);
            }

            buttonSave.Enabled = true;
        }

        // ╔══════════════════════════════════════╗
        // ║             СОХРАНЕНИЕ CSV           ║
        // ╚══════════════════════════════════════╝
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewOut.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения!", "Ошибка");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv",
                FileName = "OutPutFileTask7.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (DataGridViewRow row in dataGridViewOut.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var cells = row.Cells.Cast<DataGridViewCell>()
                            .Select(c => c.Value.ToString());

                        sw.WriteLine(string.Join(";", cells));
                    }
                }

                MessageBox.Show("Файл успешно сохранён!", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ╔══════════════════════════════════════╗
        // ║              О ПРОГРАММЕ             ║
        // ╚══════════════════════════════════════╝
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Form f = new Form
            {
                Text = "О программе",
                Size = new Size(580, 300),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            PictureBox pic = new PictureBox
            {
                Image = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\img\my_photo.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(140, 180),
                Location = new Point(20, 20)
            };

            Label lbl = new Label
            {
                Text =
                    "Девятов Егор\n" +
                    "9 класс\n" +
                    "Спринт 6 — Task 7 — Вариант 22\n" +
                    "ТИУ, 2025",
                Location = new Point(180, 40),
                AutoSize = true,
                Font = new Font("Segoe UI", 11)
            };

            Button ok = new Button
            {
                Text = "OK",
                Size = new Size(80, 30),
                Location = new Point(450, 210),
                DialogResult = DialogResult.OK
            };

            f.Controls.Add(pic);
            f.Controls.Add(lbl);
            f.Controls.Add(ok);

            f.AcceptButton = ok;

            f.ShowDialog();
        }

    }
}