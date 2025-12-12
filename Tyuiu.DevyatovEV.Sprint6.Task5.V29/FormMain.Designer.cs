using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.DevyatovEV.Sprint6.Task5.V29
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask_DEV;
        private Label labelTask_DEV;

        private FlowLayoutPanel panelButtons_DEV;
        private Button buttonExecute_DEV;
        private Button buttonOpen_DEV;
        private Button buttonInfo_DEV;

        private TableLayoutPanel layoutMain_DEV;
        private GroupBox groupBoxTable_DEV;
        private DataGridView dataGridViewValues_DEV;
        private PictureBox pictureBoxChart_DEV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxTask_DEV = new GroupBox();
            this.labelTask_DEV = new Label();

            this.panelButtons_DEV = new FlowLayoutPanel();
            this.buttonExecute_DEV = new Button();
            this.buttonOpen_DEV = new Button();
            this.buttonInfo_DEV = new Button();

            this.layoutMain_DEV = new TableLayoutPanel();
            this.groupBoxTable_DEV = new GroupBox();
            this.dataGridViewValues_DEV = new DataGridView();
            this.pictureBoxChart_DEV = new PictureBox();

            this.groupBoxTask_DEV.SuspendLayout();
            this.panelButtons_DEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_DEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart_DEV)).BeginInit();

            this.SuspendLayout();

            // groupBoxTask_DEV
            this.groupBoxTask_DEV.Controls.Add(this.labelTask_DEV);
            this.groupBoxTask_DEV.Dock = DockStyle.Top;
            this.groupBoxTask_DEV.Height = 110;
            this.groupBoxTask_DEV.Text = "Условие задачи";

            // labelTask_DEV
            this.labelTask_DEV.Dock = DockStyle.Fill;
            this.labelTask_DEV.Padding = new Padding(10);
            this.labelTask_DEV.Text =
                "Прочитать данные из файла InPutFileTask5V29.txt.\n" +
                "Вывести все значения и отдельно значения >= 10.\n" +
                "Построить график по значениям >= 10.\n" +
                "Сохранить результат в текстовый файл и график PNG.";

            // panelButtons_DEV
            this.panelButtons_DEV.Dock = DockStyle.Top;
            this.panelButtons_DEV.Height = 55;
            this.panelButtons_DEV.Padding = new Padding(10);
            this.panelButtons_DEV.FlowDirection = FlowDirection.LeftToRight;

            // buttonExecute_DEV
            this.buttonExecute_DEV.Text = "Выполнить";
            this.buttonExecute_DEV.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.buttonExecute_DEV.Size = new Size(120, 35);
            this.buttonExecute_DEV.Click += this.buttonExecute_DEV_Click;

            // buttonOpen_DEV
            this.buttonOpen_DEV.Text = "Открыть";
            this.buttonOpen_DEV.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.buttonOpen_DEV.Size = new Size(120, 35);
            this.buttonOpen_DEV.Click += this.buttonOpen_DEV_Click;

            // buttonInfo_DEV
            this.buttonInfo_DEV.Text = "Справка";
            this.buttonInfo_DEV.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.buttonInfo_DEV.Size = new Size(120, 35);
            this.buttonInfo_DEV.Click += this.buttonInfo_DEV_Click;

            this.panelButtons_DEV.Controls.Add(this.buttonExecute_DEV);
            this.panelButtons_DEV.Controls.Add(this.buttonOpen_DEV);
            this.panelButtons_DEV.Controls.Add(this.buttonInfo_DEV);

            // layoutMain_DEV
            this.layoutMain_DEV.Dock = DockStyle.Fill;
            this.layoutMain_DEV.ColumnCount = 2;
            this.layoutMain_DEV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.layoutMain_DEV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            this.layoutMain_DEV.RowCount = 1;
            this.layoutMain_DEV.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // groupBoxTable_DEV
            this.groupBoxTable_DEV.Text = "Результаты";
            this.groupBoxTable_DEV.Dock = DockStyle.Fill;
            this.groupBoxTable_DEV.Padding = new Padding(10);
            this.groupBoxTable_DEV.Controls.Add(this.dataGridViewValues_DEV);

            // dataGridViewValues_DEV
            this.dataGridViewValues_DEV.Dock = DockStyle.Fill;
            this.dataGridViewValues_DEV.AllowUserToAddRows = false;
            this.dataGridViewValues_DEV.AllowUserToDeleteRows = false;
            this.dataGridViewValues_DEV.ReadOnly = true;
            this.dataGridViewValues_DEV.RowHeadersVisible = false;
            this.dataGridViewValues_DEV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // pictureBoxChart_DEV
            this.pictureBoxChart_DEV.Dock = DockStyle.Fill;
            this.pictureBoxChart_DEV.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxChart_DEV.BackColor = Color.White;
            this.pictureBoxChart_DEV.Paint += this.pictureBoxChart_DEV_Paint;

            this.layoutMain_DEV.Controls.Add(this.groupBoxTable_DEV, 0, 0);
            this.layoutMain_DEV.Controls.Add(this.pictureBoxChart_DEV, 1, 0);

            // FormMain
            this.ClientSize = new Size(1400, 650);
            this.Controls.Add(this.layoutMain_DEV);
            this.Controls.Add(this.panelButtons_DEV);
            this.Controls.Add(this.groupBoxTask_DEV);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Task 5 | Вариант 29 | Девятов Е.В.";

            this.groupBoxTask_DEV.ResumeLayout(false);
            this.panelButtons_DEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_DEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart_DEV)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
