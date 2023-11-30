
namespace Tyuiu.GornovTA.Sprint6.Task2.V25
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxText_GTA = new System.Windows.Forms.GroupBox();
            this.labelText_GTA = new System.Windows.Forms.Label();
            this.groupBoxIn_GTA = new System.Windows.Forms.GroupBox();
            this.labelInOne_GTA = new System.Windows.Forms.Label();
            this.labelInTwo_GTA = new System.Windows.Forms.Label();
            this.textBoxInOne_GTA = new System.Windows.Forms.TextBox();
            this.textBoxInTwo_GTA = new System.Windows.Forms.TextBox();
            this.buttonDone_GTA = new System.Windows.Forms.Button();
            this.buttonInfo_GTA = new System.Windows.Forms.Button();
            this.groupBoxOut_GTA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_GTA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartGraf_GTA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxText_GTA.SuspendLayout();
            this.groupBoxIn_GTA.SuspendLayout();
            this.groupBoxOut_GTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_GTA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxText_GTA
            // 
            this.groupBoxText_GTA.Controls.Add(this.labelText_GTA);
            this.groupBoxText_GTA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxText_GTA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxText_GTA.Name = "groupBoxText_GTA";
            this.groupBoxText_GTA.Size = new System.Drawing.Size(442, 375);
            this.groupBoxText_GTA.TabIndex = 0;
            this.groupBoxText_GTA.TabStop = false;
            this.groupBoxText_GTA.Text = "Условие";
            // 
            // labelText_GTA
            // 
            this.labelText_GTA.AutoSize = true;
            this.labelText_GTA.Location = new System.Drawing.Point(7, 20);
            this.labelText_GTA.Name = "labelText_GTA";
            this.labelText_GTA.Size = new System.Drawing.Size(434, 45);
            this.labelText_GTA.TabIndex = 0;
            this.labelText_GTA.Text = "Протабулировать функцию ((5*x+2,5)/(sin(x)-2))+2 \r\nна заданном диапазоне.\r\nРезуль" +
    "тат вывести в DataGrid View и построить график функции.";
            // 
            // groupBoxIn_GTA
            // 
            this.groupBoxIn_GTA.Controls.Add(this.textBoxInTwo_GTA);
            this.groupBoxIn_GTA.Controls.Add(this.textBoxInOne_GTA);
            this.groupBoxIn_GTA.Controls.Add(this.labelInTwo_GTA);
            this.groupBoxIn_GTA.Controls.Add(this.labelInOne_GTA);
            this.groupBoxIn_GTA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxIn_GTA.Location = new System.Drawing.Point(12, 394);
            this.groupBoxIn_GTA.Name = "groupBoxIn_GTA";
            this.groupBoxIn_GTA.Size = new System.Drawing.Size(272, 68);
            this.groupBoxIn_GTA.TabIndex = 1;
            this.groupBoxIn_GTA.TabStop = false;
            this.groupBoxIn_GTA.Text = "Ввод данных";
            // 
            // labelInOne_GTA
            // 
            this.labelInOne_GTA.AutoSize = true;
            this.labelInOne_GTA.Location = new System.Drawing.Point(7, 20);
            this.labelInOne_GTA.Name = "labelInOne_GTA";
            this.labelInOne_GTA.Size = new System.Drawing.Size(84, 15);
            this.labelInOne_GTA.TabIndex = 0;
            this.labelInOne_GTA.Text = "Страт шага:";
            // 
            // labelInTwo_GTA
            // 
            this.labelInTwo_GTA.AutoSize = true;
            this.labelInTwo_GTA.Location = new System.Drawing.Point(137, 21);
            this.labelInTwo_GTA.Name = "labelInTwo_GTA";
            this.labelInTwo_GTA.Size = new System.Drawing.Size(84, 15);
            this.labelInTwo_GTA.TabIndex = 1;
            this.labelInTwo_GTA.Text = "Конец шага:";
            // 
            // textBoxInOne_GTA
            // 
            this.textBoxInOne_GTA.Location = new System.Drawing.Point(7, 39);
            this.textBoxInOne_GTA.Name = "textBoxInOne_GTA";
            this.textBoxInOne_GTA.Size = new System.Drawing.Size(127, 23);
            this.textBoxInOne_GTA.TabIndex = 2;
            // 
            // textBoxInTwo_GTA
            // 
            this.textBoxInTwo_GTA.Location = new System.Drawing.Point(140, 39);
            this.textBoxInTwo_GTA.Name = "textBoxInTwo_GTA";
            this.textBoxInTwo_GTA.Size = new System.Drawing.Size(127, 23);
            this.textBoxInTwo_GTA.TabIndex = 3;
            // 
            // buttonDone_GTA
            // 
            this.buttonDone_GTA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_GTA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_GTA.Location = new System.Drawing.Point(360, 402);
            this.buttonDone_GTA.Name = "buttonDone_GTA";
            this.buttonDone_GTA.Size = new System.Drawing.Size(95, 60);
            this.buttonDone_GTA.TabIndex = 1;
            this.buttonDone_GTA.Text = "Выполнить";
            this.buttonDone_GTA.UseVisualStyleBackColor = false;
            this.buttonDone_GTA.Click += new System.EventHandler(this.buttonDone_GTA_Click);
            this.buttonDone_GTA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_GTA_MouseDown);
            this.buttonDone_GTA.MouseEnter += new System.EventHandler(this.buttonDone_GTA_MouseEnter);
            this.buttonDone_GTA.MouseLeave += new System.EventHandler(this.buttonDone_GTA_MouseLeave);
            // 
            // buttonInfo_GTA
            // 
            this.buttonInfo_GTA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_GTA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_GTA.Location = new System.Drawing.Point(290, 402);
            this.buttonInfo_GTA.Name = "buttonInfo_GTA";
            this.buttonInfo_GTA.Size = new System.Drawing.Size(64, 60);
            this.buttonInfo_GTA.TabIndex = 2;
            this.buttonInfo_GTA.Text = "Справка";
            this.buttonInfo_GTA.UseVisualStyleBackColor = false;
            this.buttonInfo_GTA.Click += new System.EventHandler(this.buttonInfo_GTA_Click);
            // 
            // groupBoxOut_GTA
            // 
            this.groupBoxOut_GTA.Controls.Add(this.chartGraf_GTA);
            this.groupBoxOut_GTA.Controls.Add(this.dataGridViewOut_GTA);
            this.groupBoxOut_GTA.Location = new System.Drawing.Point(460, 13);
            this.groupBoxOut_GTA.Name = "groupBoxOut_GTA";
            this.groupBoxOut_GTA.Size = new System.Drawing.Size(474, 449);
            this.groupBoxOut_GTA.TabIndex = 3;
            this.groupBoxOut_GTA.TabStop = false;
            this.groupBoxOut_GTA.Text = "Вывод данных";
            // 
            // dataGridViewOut_GTA
            // 
            this.dataGridViewOut_GTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_GTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Function});
            this.dataGridViewOut_GTA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOut_GTA.Name = "dataGridViewOut_GTA";
            this.dataGridViewOut_GTA.RowHeadersVisible = false;
            this.dataGridViewOut_GTA.Size = new System.Drawing.Size(104, 423);
            this.dataGridViewOut_GTA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Function
            // 
            this.Function.HeaderText = "F(x)";
            this.Function.Name = "Function";
            this.Function.ReadOnly = true;
            this.Function.Width = 50;
            // 
            // chartGraf_GTA
            // 
            chartArea9.Name = "ChartArea1";
            this.chartGraf_GTA.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartGraf_GTA.Legends.Add(legend9);
            this.chartGraf_GTA.Location = new System.Drawing.Point(117, 20);
            this.chartGraf_GTA.Name = "chartGraf_GTA";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartGraf_GTA.Series.Add(series9);
            this.chartGraf_GTA.Size = new System.Drawing.Size(351, 423);
            this.chartGraf_GTA.TabIndex = 1;
            this.chartGraf_GTA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 474);
            this.Controls.Add(this.groupBoxOut_GTA);
            this.Controls.Add(this.buttonInfo_GTA);
            this.Controls.Add(this.buttonDone_GTA);
            this.Controls.Add(this.groupBoxIn_GTA);
            this.Controls.Add(this.groupBoxText_GTA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 25 | Горнов Т.А.";
            this.groupBoxText_GTA.ResumeLayout(false);
            this.groupBoxText_GTA.PerformLayout();
            this.groupBoxIn_GTA.ResumeLayout(false);
            this.groupBoxIn_GTA.PerformLayout();
            this.groupBoxOut_GTA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_GTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText_GTA;
        private System.Windows.Forms.Label labelText_GTA;
        private System.Windows.Forms.GroupBox groupBoxIn_GTA;
        private System.Windows.Forms.TextBox textBoxInTwo_GTA;
        private System.Windows.Forms.TextBox textBoxInOne_GTA;
        private System.Windows.Forms.Label labelInTwo_GTA;
        private System.Windows.Forms.Label labelInOne_GTA;
        private System.Windows.Forms.Button buttonDone_GTA;
        private System.Windows.Forms.Button buttonInfo_GTA;
        private System.Windows.Forms.GroupBox groupBoxOut_GTA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_GTA;
        private System.Windows.Forms.DataGridView dataGridViewOut_GTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
    }
}

