using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task7.V22
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask;
        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;

        private FlowLayoutPanel panelButtons;

        private Button buttonLoad;
        private Button buttonProcess;
        private Button buttonSave;
        private Button buttonInfo;

        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;

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
            Label labelTask = new Label();

            panelButtons = new FlowLayoutPanel();
            buttonLoad = new Button();
            buttonProcess = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();

            groupBoxIn = new GroupBox();
            dataGridViewIn = new DataGridView();

            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();

            labelFileInfo = new Label();

            SuspendLayout();

            //
            // groupBoxTask
            //
            groupBoxTask.Text = "Условие задачи";
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Height = 100;
            groupBoxTask.Padding = new Padding(10);

            labelTask.Text =
                "Дан файл InPutFileTask7V22.csv, в котором хранится матрица целочисленных значений.\r\n" +
                "Загрузить файл через openFileDialog в dataGridViewIn.\r\n" +
                "Изменить в шестом столбце положительные четные элементы на 111.\r\n" +
                "Сохранить результат в OutPutFileTask7.csv.";
            labelTask.Dock = DockStyle.Fill;
            labelTask.Padding = new Padding(10);
            labelTask.Font = new Font("Arial", 9.5f);
            groupBoxTask.Controls.Add(labelTask);

            //
            // panelButtons
            //
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Height = 70;
            panelButtons.Padding = new Padding(20, 10, 20, 10);
            panelButtons.FlowDirection = FlowDirection.LeftToRight;
            panelButtons.WrapContents = false;

            //
            // buttonLoad
            //
            buttonLoad.Size = new Size(48, 48);
            buttonLoad.BackgroundImage = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\img\folder_add.png");
            buttonLoad.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLoad.FlatStyle = FlatStyle.Flat;
            buttonLoad.Click += buttonLoad_Click;
            buttonLoad.Cursor = Cursors.Hand;
            buttonLoad.Margin = new Padding(4);

            //
            // buttonProcess
            //
            buttonProcess.Size = new Size(48, 48);
            buttonProcess.BackgroundImage = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\img\page_white_go.png");
            buttonProcess.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProcess.FlatStyle = FlatStyle.Flat;
            buttonProcess.Enabled = false;
            buttonProcess.Click += buttonProcess_Click;
            buttonProcess.Cursor = Cursors.Hand;
            buttonProcess.Margin = new Padding(4);

            //
            // buttonSave
            //
            buttonSave.Size = new Size(48, 48);
            buttonSave.BackgroundImage = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\img\save.png");
            buttonSave.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Enabled = false;
            buttonSave.Click += buttonSave_Click;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Margin = new Padding(4);

            //
            // buttonInfo
            //
            buttonInfo.Size = new Size(48, 48);
            buttonInfo.BackgroundImage = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.DevyatovEV.Sprint6\img\help.png");
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Click += buttonInfo_Click;
            buttonInfo.Cursor = Cursors.Hand;
            buttonInfo.Margin = new Padding(4);

            panelButtons.Controls.Add(buttonLoad);
            panelButtons.Controls.Add(buttonProcess);
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Controls.Add(buttonInfo);

            //
            // groupBoxIn
            //
            groupBoxIn.Text = "Исходная матрица";
            groupBoxIn.Dock = DockStyle.Left;
            groupBoxIn.Width = 520;
            groupBoxIn.Padding = new Padding(8);

            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.RowHeadersWidth = 50;
            dataGridViewIn.AllowUserToAddRows = false;
            dataGridViewIn.AllowUserToDeleteRows = false;
            dataGridViewIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            groupBoxIn.Controls.Add(dataGridViewIn);

            //
            // groupBoxOut
            //
            groupBoxOut.Text = "Обработанная матрица";
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Padding = new Padding(8);

            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersWidth = 50;
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToDeleteRows = false;
            dataGridViewOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            groupBoxOut.Controls.Add(dataGridViewOut);

            //
            // labelFileInfo
            //
            labelFileInfo.AutoSize = true;
            labelFileInfo.ForeColor = Color.DarkBlue;
            labelFileInfo.Location = new Point(20, 170);
            labelFileInfo.Text = "Файл не выбран";

            //
            // FormMain
            //
            ClientSize = new Size(1200, 760);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxIn);
            Controls.Add(labelFileInfo);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxTask);

            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(1000, 700);
            Text = "Спринт 6 | Task 7 | Вариант 22 | Девятов Е.В.";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
