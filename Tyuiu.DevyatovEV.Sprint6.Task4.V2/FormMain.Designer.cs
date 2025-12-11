using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task4.V2
{
    partial class FormMain
    {
        private TextBox textBoxResult;
        private PictureBox pictureBoxChart;
        private Button buttonExecute;
        private Button buttonSave;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            textBoxResult = new TextBox();
            pictureBoxChart = new PictureBox();
            buttonExecute = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();

            textBoxResult.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResult.Location = new Point(20, 20);
            textBoxResult.Multiline = true;
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(350, 400);

            pictureBoxChart.BackColor = Color.White;
            pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxChart.Location = new Point(390, 20);
            pictureBoxChart.Size = new Size(500, 400);
            pictureBoxChart.Paint += pictureBoxChart_Paint;

            buttonExecute.Text = "Выполнить";
            buttonExecute.Location = new Point(20, 440);
            buttonExecute.Size = new Size(110, 35);
            buttonExecute.Click += buttonExecute_Click;

            buttonSave.Text = "Сохранить";
            buttonSave.Location = new Point(140, 440);
            buttonSave.Size = new Size(110, 35);
            buttonSave.Click += buttonSave_Click;

            buttonInfo.Text = "Информация";
            buttonInfo.Location = new Point(260, 440);
            buttonInfo.Size = new Size(110, 35);
            buttonInfo.Click += buttonInfo_Click;

            ClientSize = new Size(910, 490);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 4 | Вариант 2 | Девятов Е.В.";

            Controls.Add(textBoxResult);
            Controls.Add(pictureBoxChart);
            Controls.Add(buttonExecute);
            Controls.Add(buttonSave);
            Controls.Add(buttonInfo);
        }
    }
}