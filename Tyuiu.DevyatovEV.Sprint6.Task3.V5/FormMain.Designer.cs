using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task3.V5
{
    partial class FormMain
    {
        private DataGridView dataGridViewResult;
        private Button buttonExecute;
        private Button buttonInfo;
        private Label labelTask;
        private TextBox textBoxTask;

        private void InitializeComponent()
        {
            labelTask = new Label();
            textBoxTask = new TextBox();
            dataGridViewResult = new DataGridView();
            buttonExecute = new Button();
            buttonInfo = new Button();

            // labelTask
            labelTask.AutoSize = true;
            labelTask.Location = new Point(20, 10);
            labelTask.Text = "Задание:";

            // textBoxTask
            textBoxTask.Location = new Point(20, 30);
            textBoxTask.Size = new Size(500, 120);
            textBoxTask.Multiline = true;
            textBoxTask.ReadOnly = true;
            textBoxTask.ScrollBars = ScrollBars.Vertical;
            textBoxTask.Text =
                "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию\r\n" +
                "в третьем столбце.\r\n\r\nИсходный массив:\r\n" +
                "  30 -20   7  -8   9\r\n" +
                "  32  17 -14  -7  33\r\n" +
                "  19 -19 -13  14 -20\r\n" +
                "  11  30  -1  26   6\r\n" +
                "  30 -15 -20  -5  15";

            // dataGridViewResult
            dataGridViewResult.Location = new Point(20, 160);
            dataGridViewResult.Size = new Size(500, 250);
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.AllowUserToAddRows = false;

            // buttonExecute
            buttonExecute.Text = "Выполнить";
            buttonExecute.Location = new Point(350, 420);
            buttonExecute.Size = new Size(100, 30);
            buttonExecute.Click += buttonExecute_Click;

            // buttonInfo
            buttonInfo.Text = "?";
            buttonInfo.Location = new Point(460, 420);
            buttonInfo.Size = new Size(40, 30);
            buttonInfo.Click += buttonInfo_Click;

            // FormMain
            ClientSize = new Size(550, 470);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 3 | Вариант 5 | Девятов Е.В.";

            Controls.Add(labelTask);
            Controls.Add(textBoxTask);
            Controls.Add(dataGridViewResult);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
        }
    }
}