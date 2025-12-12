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
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).BeginInit();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Courier New", 9.75F);
            textBoxResult.Location = new Point(20, 20);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(350, 409);
            textBoxResult.TabIndex = 0;
            // 
            // pictureBoxChart
            // 
            pictureBoxChart.BackColor = Color.White;
            pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxChart.Location = new Point(390, 20);
            pictureBoxChart.Name = "pictureBoxChart";
            pictureBoxChart.Size = new Size(554, 409);
            pictureBoxChart.TabIndex = 1;
            pictureBoxChart.TabStop = false;
            pictureBoxChart.Paint += pictureBoxChart_Paint;
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(20, 440);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(110, 35);
            buttonExecute.TabIndex = 2;
            buttonExecute.Text = "Выполнить";
            buttonExecute.Click += buttonExecute_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(140, 440);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 35);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(260, 440);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(110, 35);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "Информация";
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(963, 534);
            Controls.Add(textBoxResult);
            Controls.Add(pictureBoxChart);
            Controls.Add(buttonExecute);
            Controls.Add(buttonSave);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 4 | Вариант 2 | Девятов Е.В.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}