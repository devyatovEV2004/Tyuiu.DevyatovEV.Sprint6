using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task2.V12
{
    partial class FormMain
    {
        private PictureBox pictureFormula;
        private DataGridView dataGridViewResult;
        private Button buttonExecute;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            pictureFormula = new PictureBox();
            dataGridViewResult = new DataGridView();
            buttonExecute = new Button();
            buttonInfo = new Button();

            // PictureBox с формулой
            pictureFormula.ImageLocation = @"C:\Users\Egor\source\repos\Tyuiu.DevyatovEV.Sprint6\img\task2.png";
            pictureFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFormula.Location = new Point(20, 20);
            pictureFormula.Size = new Size(500, 120);

            // DataGridView для результатов
            dataGridViewResult.Location = new Point(20, 160);
            dataGridViewResult.Size = new Size(500, 260);
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.AllowUserToAddRows = false;

            // Кнопка Выполнить
            buttonExecute.Text = "Выполнить";
            buttonExecute.Location = new Point(320, 430);
            buttonExecute.Size = new Size(100, 30);
            buttonExecute.Click += buttonExecute_Click;

            // Кнопка Информация
            buttonInfo.Text = "?";
            buttonInfo.Location = new Point(430, 430);
            buttonInfo.Size = new Size(40, 30);
            buttonInfo.Click += buttonInfo_Click;

            // Настройки формы
            ClientSize = new Size(550, 480);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 2 | Вариант 12 | Девятов Е.В.";

            Controls.Add(pictureFormula);
            Controls.Add(dataGridViewResult);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
        }
    }
}