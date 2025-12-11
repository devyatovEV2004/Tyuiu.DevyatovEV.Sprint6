using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task7.V22
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Button buttonOpen;
        private Button buttonProcess;
        private Button buttonInfo;
        private Label labelIn;
        private Label labelOut;
        private Label labelFileInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            buttonOpen = new Button();
            buttonProcess = new Button();
            buttonInfo = new Button();
            labelIn = new Label();
            labelOut = new Label();
            labelFileInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();

            buttonOpen.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpen.Location = new Point(20, 20);
            buttonOpen.Size = new Size(150, 35);
            buttonOpen.Text = "Выбрать файл";
            buttonOpen.Click += buttonOpen_Click;

            buttonProcess.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProcess.Location = new Point(180, 20);
            buttonProcess.Size = new Size(150, 35);
            buttonProcess.Text = "Обработать";
            buttonProcess.Enabled = false;
            buttonProcess.Click += buttonProcess_Click;

            buttonInfo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInfo.Location = new Point(750, 20);
            buttonInfo.Size = new Size(35, 35);
            buttonInfo.Text = "?";
            buttonInfo.Click += buttonInfo_Click;

            labelFileInfo.AutoSize = true;
            labelFileInfo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelFileInfo.ForeColor = Color.DarkBlue;
            labelFileInfo.Location = new Point(340, 30);

            labelIn.AutoSize = true;
            labelIn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelIn.Location = new Point(20, 70);
            labelIn.Text = "Исходная матрица";

            dataGridViewIn.AllowUserToAddRows = false;
            dataGridViewIn.AllowUserToDeleteRows = false;
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(20, 90);
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.RowHeadersVisible = true;
            dataGridViewIn.Size = new Size(380, 350);

            labelOut.AutoSize = true;
            labelOut.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelOut.Location = new Point(420, 70);
            labelOut.Text = "Обработанная матрица";

            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToDeleteRows = false;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(420, 90);
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersVisible = true;
            dataGridViewOut.Size = new Size(380, 350);

            ClientSize = new Size(820, 460);
            Controls.Add(dataGridViewOut);
            Controls.Add(labelOut);
            Controls.Add(dataGridViewIn);
            Controls.Add(labelIn);
            Controls.Add(labelFileInfo);
            Controls.Add(buttonInfo);
            Controls.Add(buttonProcess);
            Controls.Add(buttonOpen);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 7 | Вариант 22 | Девятов Е.В.";

            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}