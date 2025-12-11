using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task0.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox picFormula;
        private TextBox textBoxResult;
        private Button btnRun;
        private Button btnInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            picFormula = new PictureBox();
            textBoxResult = new TextBox();
            btnRun = new Button();
            btnInfo = new Button();

            ((System.ComponentModel.ISupportInitialize)picFormula).BeginInit();
            SuspendLayout();

            // PictureBox с формулой
            picFormula.ImageLocation = @"C:\Users\Egor\source\repos\Tyuiu.DevyatovEV.Sprint6\img\task0.png";
            picFormula.Location = new Point(20, 20);
            picFormula.Size = new Size(400, 50);
            picFormula.SizeMode = PictureBoxSizeMode.Zoom;

            // TextBox для результата
            textBoxResult.Location = new Point(20, 90);
            textBoxResult.Multiline = true;
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(400, 80);
            textBoxResult.Font = new Font("Microsoft Sans Serif", 10F);

            // Кнопка Выполнить
            btnRun.Location = new Point(240, 180);
            btnRun.Size = new Size(90, 25);
            btnRun.Text = "Выполнить";
            btnRun.Click += buttonExecute_Click;

            // Кнопка Информация
            btnInfo.Location = new Point(340, 180);
            btnInfo.Size = new Size(30, 25);
            btnInfo.Text = "?";
            btnInfo.Click += buttonInfo_Click;

            // Настройки формы
            ClientSize = new Size(450, 220);
            Controls.Add(picFormula);
            Controls.Add(textBoxResult);
            Controls.Add(btnRun);
            Controls.Add(btnInfo);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 0 | Вариант 23";

            ((System.ComponentModel.ISupportInitialize)picFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}