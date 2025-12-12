using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.DevyatovEV.Sprint6.Task6.V5.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        private string? selectedFile;
        private readonly DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                    Title = "Выберите текстовый файл"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = ofd.FileName;
                    textBoxIn.Text = File.ReadAllText(selectedFile);

                    buttonProcess.Enabled = true;
                    buttonSave.Enabled = false;

                    labelFileInfo.Text = "Файл: " + Path.GetFileName(selectedFile);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIn.Text))
            {
                MessageBox.Show("Нет текста для обработки. Сначала загрузите файл!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Сохраняем текст во временный файл (как делает Иван)
                string tempPath = Path.GetTempFileName();
                File.WriteAllText(tempPath, textBoxIn.Text);

                // Обработка
                string result = ds.CollectTextFromFile(tempPath);

                textBoxOut.Text = result;
                buttonSave.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка обработки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOut.Text))
            {
                MessageBox.Show("Нет данных для сохранения!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                FileName = "OutPutTask6V5.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sfd.FileName, textBoxOut.Text);
                    MessageBox.Show("Файл успешно сохранён!", "Успех");
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения файла!", "Ошибка");
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Form f = new Form
            {
                Text = "О программе",
                Size = new Size(580, 330),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            // Фото автора — поменяй путь на свой
            PictureBox pic = new PictureBox
            {
                Image = Image.FromFile(
                    @"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\img\my_photo.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(20, 20),
                Size = new Size(120, 160)
            };

            // Текст о программе
            Label lbl = new Label
            {
                Text = "Девятов Егор\n9 класс\nСпринт 6 — Задание 6\nВариант 5\nТИУ 2025",
                Location = new Point(160, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };

            Button ok = new Button
            {
                Text = "OK",
                Location = new Point(380, 240),
                Size = new Size(80, 30),
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
