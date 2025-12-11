using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task1.V21
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
            picFormula.ImageLocation = @"C:\Users\Egor\source\repos\Tyuiu.DevyatovEV.Sprint6\img\task1.png";
            picFormula.Location = new Point(20, 20);
            picFormula.Size = new Size(500, 120);
            picFormula.SizeMode = PictureBoxSizeMode.Zoom;

            // TextBox для результата
            textBoxResult.Location = new Point(20, 160);
            textBoxResult.Multiline = true;
            textBoxResult.ReadOnly = true;
            textBoxResult.Font = new Font("Courier New", 10f);
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(500, 250);

            // Кнопка Выполнить
            btnRun.Location = new Point(320, 420);
            btnRun.Size = new Size(100, 30);
            btnRun.Text = "Выполнить";
            btnRun.Click += buttonExecute_Click;

            // Кнопка Информация
            btnInfo.Location = new Point(430, 420);
            btnInfo.Size = new Size(40, 30);
            btnInfo.Text = "?";
            btnInfo.Click += buttonInfo_Click;

            // Настройки формы
            ClientSize = new Size(550, 470);
            Controls.Add(picFormula);
            Controls.Add(textBoxResult);
            Controls.Add(btnRun);
            Controls.Add(btnInfo);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 1 | Вариант 21";

            ((System.ComponentModel.ISupportInitialize)picFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}