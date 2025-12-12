using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task6.V5
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask;
        private Label labelTask;

        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;

        private TextBox textBoxIn;
        private TextBox textBoxOut;

        private FlowLayoutPanel panelButtons;
        private Button buttonLoad;
        private Button buttonProcess;
        private Button buttonSave;
        private Button buttonInfo;

        private Label labelFileInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            groupBoxTask = new GroupBox();
            labelTask = new Label();

            groupBoxIn = new GroupBox();
            groupBoxOut = new GroupBox();

            textBoxIn = new TextBox();
            textBoxOut = new TextBox();

            panelButtons = new FlowLayoutPanel();

            buttonLoad = new Button();
            buttonProcess = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();

            labelFileInfo = new Label();

            SuspendLayout();

            // -------------------------
            // groupBoxTask
            // -------------------------
            groupBoxTask.Text = "Условие задания";
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Height = 80;

            labelTask.Text = "Дан текстовый файл. Вывести все слова, содержащие букву 'l'.";
            labelTask.Dock = DockStyle.Fill;
            labelTask.Padding = new Padding(10);
            labelTask.Font = new Font("Segoe UI", 10);

            groupBoxTask.Controls.Add(labelTask);

            // -------------------------
            // panelButtons
            // -------------------------
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Height = 60;
            panelButtons.Padding = new Padding(10);
            panelButtons.FlowDirection = FlowDirection.LeftToRight;

            string imgPath = @"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\img\";

            Size btnSize = new Size(45, 45);

            // buttonLoad
            buttonLoad.Size = btnSize;
            buttonLoad.BackgroundImage = Image.FromFile(imgPath + "folder_add.png");
            buttonLoad.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLoad.Click += buttonLoad_Click;

            // buttonProcess
            buttonProcess.Size = btnSize;
            buttonProcess.BackgroundImage = Image.FromFile(imgPath + "page_white_go.png");
            buttonProcess.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProcess.Enabled = false;
            buttonProcess.Click += buttonProcess_Click;

            // buttonSave
            buttonSave.Size = btnSize;
            buttonSave.BackgroundImage = Image.FromFile(imgPath + "save.png");
            buttonSave.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave.Enabled = false;
            buttonSave.Click += buttonSave_Click;

            // buttonInfo
            buttonInfo.Size = btnSize;
            buttonInfo.BackgroundImage = Image.FromFile(imgPath + "help.png");
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo.Click += buttonInfo_Click;

            panelButtons.Controls.Add(buttonLoad);
            panelButtons.Controls.Add(buttonProcess);
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Controls.Add(buttonInfo);

            // -------------------------
            // groupBoxIn — text input
            // -------------------------
            groupBoxIn.Text = "Исходный текст";
            groupBoxIn.Dock = DockStyle.Left;
            groupBoxIn.Width = 480;

            textBoxIn.Multiline = true;
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.ScrollBars = ScrollBars.Vertical;

            groupBoxIn.Controls.Add(textBoxIn);

            // -------------------------
            // groupBoxOut — result
            // -------------------------
            groupBoxOut.Text = "Результат";
            groupBoxOut.Dock = DockStyle.Fill;

            textBoxOut.Multiline = true;
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.ScrollBars = ScrollBars.Vertical;

            groupBoxOut.Controls.Add(textBoxOut);

            // -------------------------
            // labelFileInfo
            // -------------------------
            labelFileInfo.AutoSize = true;
            labelFileInfo.ForeColor = Color.DarkBlue;
            labelFileInfo.Location = new Point(10, 140);

            // -------------------------
            // Main Form
            // -------------------------
            ClientSize = new Size(1000, 600);

            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxIn);
            Controls.Add(labelFileInfo);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxTask);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Задание 6 | Вариант 5 | Девятов Е.В.";
            MinimumSize = new Size(1000, 600);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
