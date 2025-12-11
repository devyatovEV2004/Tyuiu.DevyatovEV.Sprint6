using System;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task6.V5.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.DevyatovEV.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        private string selectedFile = "";
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                    Title = "Выберите файл для обработки",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = ofd.FileName;
                    textBoxIn.Text = System.IO.File.ReadAllText(selectedFile);
                    buttonProcess.Enabled = true;
                    labelFileInfo.Text = $"Выбран файл: {System.IO.Path.GetFileName(selectedFile)}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedFile))
                {
                    MessageBox.Show("Сначала выберите файл!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!System.IO.File.Exists(selectedFile))
                {
                    MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                textBoxOut.Text = ds.CollectTextFromFile(selectedFile);
                int wordCount = textBoxOut.Text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                labelStats.Text = $"Найдено слов с буквой 'l': {wordCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Task 6 | Вариант 5\nВыполнил: Девятов Егор Владимирович\n\n" +
                "Программа загружает текстовый файл и выводит слова,\nкоторые содержат букву 'l' (регистр не учитывается).",
                "Информация о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}