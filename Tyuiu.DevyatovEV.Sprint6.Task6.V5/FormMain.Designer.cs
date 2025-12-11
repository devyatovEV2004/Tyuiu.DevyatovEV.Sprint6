using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task6.V5
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private Button buttonOpen;
        private Button buttonProcess;
        private Button buttonInfo;
        private Label labelIn;
        private Label labelOut;
        private Label labelFileInfo;
        private Label labelStats;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxIn = new TextBox();
            textBoxOut = new TextBox();
            buttonOpen = new Button();
            buttonProcess = new Button();
            buttonInfo = new Button();
            labelIn = new Label();
            labelOut = new Label();
            labelFileInfo = new Label();
            labelStats = new Label();
            SuspendLayout();

            // Кнопка Открыть файл
            buttonOpen.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpen.Location = new Point(20, 20);
            buttonOpen.Size = new Size(150, 35);
            buttonOpen.Text = "Открыть файл";
            buttonOpen.Click += buttonOpen_Click;

            // Кнопка Обработать
            buttonProcess.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProcess.Location = new Point(180, 20);
            buttonProcess.Size = new Size(150, 35);
            buttonProcess.Text = "Обработать";
            buttonProcess.Enabled = false;
            buttonProcess.Click += buttonProcess_Click;

            // Кнопка Информация
            buttonInfo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInfo.Location = new Point(760, 20);
            buttonInfo.Size = new Size(35, 35);
            buttonInfo.Text = "?";
            buttonInfo.Click += buttonInfo_Click;

            // Метка информации о файле
            labelFileInfo.AutoSize = true;
            labelFileInfo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelFileInfo.ForeColor = Color.DarkBlue;
            labelFileInfo.Location = new Point(340, 30);

            // Метка для исходного текста
            labelIn.AutoSize = true;
            labelIn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelIn.Location = new Point(20, 70);
            labelIn.Text = "Содержимое файла:";

            // TextBox для исходного текста
            textBoxIn.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIn.Location = new Point(20, 90);
            textBoxIn.Multiline = true;
            textBoxIn.ReadOnly = true;
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(380, 350);

            // Метка для результата
            labelOut.AutoSize = true;
            labelOut.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelOut.Location = new Point(420, 70);
            labelOut.Text = "Слова, содержащие букву 'l':";

            // TextBox для результата
            textBoxOut.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOut.Location = new Point(420, 90);
            textBoxOut.Multiline = true;
            textBoxOut.ReadOnly = true;
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(380, 350);

            // Метка статистики
            labelStats.AutoSize = true;
            labelStats.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelStats.ForeColor = Color.DarkGreen;
            labelStats.Location = new Point(420, 450);

            // Настройки формы
            ClientSize = new Size(820, 480);
            Controls.Add(labelStats);
            Controls.Add(textBoxOut);
            Controls.Add(labelOut);
            Controls.Add(textBoxIn);
            Controls.Add(labelIn);
            Controls.Add(labelFileInfo);
            Controls.Add(buttonInfo);
            Controls.Add(buttonProcess);
            Controls.Add(buttonOpen);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 6 | Вариант 5 | Девятов Е.В.";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}