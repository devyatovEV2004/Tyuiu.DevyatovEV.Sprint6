using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task7.V22.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task7.V22
{
    public partial class FormMain : Form
    {
        string selectedPath = "";
        DataService ds = new DataService();
        int[,] matrix;

        public FormMain() => InitializeComponent();

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    Title = "Выберите файл с матрицей",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = ofd.FileName;
                    matrix = ds.GetMatrix(selectedPath);
                    dataGridViewIn.DataSource = ToDataTable(matrix);
                    buttonProcess.Enabled = true;
                    string fileName = Path.GetFileName(selectedPath);
                    labelFileInfo.Text = $"Загружен файл: {fileName} | Размер: {matrix.GetLength(0)}x{matrix.GetLength(1)}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrix == null)
                {
                    MessageBox.Show("Сначала выберите файл с матрицей!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[,] resultMatrix = ds.ProcessMatrix(matrix);
                dataGridViewOut.DataSource = ToDataTable(resultMatrix);
                ConfigureDataGridView(dataGridViewOut);

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    FileName = "OutPutFileTask7V22.csv",
                    Title = "Сохранить результат",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ds.SaveMatrix(resultMatrix, sfd.FileName);
                    MessageBox.Show($"Файл успешно сохранен:\n{sfd.FileName}", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке матрицы:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Task 7 | Вариант 22\nВыполнил: Девятов Егор Владимирович\n\nПрограмма загружает матрицу из CSV файла.\nВ шестом столбце заменяет положительные четные элементы на 111.\nРезультат сохраняется в CSV файл.", "Информация о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DataTable ToDataTable(int[,] array)
        {
            int rows = array.GetLength(0), cols = array.GetLength(1);
            DataTable dt = new DataTable();
            for (int c = 0; c < cols; c++) dt.Columns.Add($"Столбец {c + 1}", typeof(string));
            for (int r = 0; r < rows; r++)
            {
                DataRow dr = dt.NewRow();
                for (int c = 0; c < cols; c++) dr[c] = array[r, c].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = true;
            dgv.ColumnHeadersVisible = true;
            for (int i = 0; i < dgv.Rows.Count; i++) dgv.Rows[i].HeaderCell.Value = $"Строка {i + 1}";
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            if (dgv.Columns.Count > 5)
            {
                dgv.Columns[5].DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                dgv.Columns[5].DefaultCellStyle.Font = new System.Drawing.Font(dgv.Font, System.Drawing.FontStyle.Bold);
            }
        }
    }
}