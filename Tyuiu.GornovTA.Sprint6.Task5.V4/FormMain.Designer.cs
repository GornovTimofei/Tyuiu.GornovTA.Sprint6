
namespace Tyuiu.GornovTA.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxText_GTA = new System.Windows.Forms.GroupBox();
            this.labelText_GTA = new System.Windows.Forms.Label();
            this.buttonDone_GTA = new System.Windows.Forms.Button();
            this.buttonFile_GTA = new System.Windows.Forms.Button();
            this.buttonInfo_GTA = new System.Windows.Forms.Button();
            this.groupBoxOut_GTA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_GTA = new System.Windows.Forms.DataGridView();
            this.chartDiagram_GTA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxText_GTA.SuspendLayout();
            this.groupBoxOut_GTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_GTA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxText_GTA
            // 
            this.groupBoxText_GTA.Controls.Add(this.labelText_GTA);
            this.groupBoxText_GTA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxText_GTA.Name = "groupBoxText_GTA";
            this.groupBoxText_GTA.Size = new System.Drawing.Size(548, 70);
            this.groupBoxText_GTA.TabIndex = 0;
            this.groupBoxText_GTA.TabStop = false;
            this.groupBoxText_GTA.Text = "Условие";
            // 
            // labelText_GTA
            // 
            this.labelText_GTA.AutoSize = true;
            this.labelText_GTA.Location = new System.Drawing.Point(7, 23);
            this.labelText_GTA.Name = "labelText_GTA";
            this.labelText_GTA.Size = new System.Drawing.Size(497, 30);
            this.labelText_GTA.TabIndex = 0;
            this.labelText_GTA.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView\r\nцелые чис" +
    "ла и построить диаграмму по этим значениям.";
            // 
            // buttonDone_GTA
            // 
            this.buttonDone_GTA.Location = new System.Drawing.Point(567, 13);
            this.buttonDone_GTA.Name = "buttonDone_GTA";
            this.buttonDone_GTA.Size = new System.Drawing.Size(114, 70);
            this.buttonDone_GTA.TabIndex = 1;
            this.buttonDone_GTA.Text = "Выполнить";
            this.buttonDone_GTA.UseVisualStyleBackColor = true;
            this.buttonDone_GTA.Click += new System.EventHandler(this.buttonDone_GTA_Click);
            // 
            // buttonFile_GTA
            // 
            this.buttonFile_GTA.Location = new System.Drawing.Point(687, 12);
            this.buttonFile_GTA.Name = "buttonFile_GTA";
            this.buttonFile_GTA.Size = new System.Drawing.Size(114, 70);
            this.buttonFile_GTA.TabIndex = 2;
            this.buttonFile_GTA.Text = "Открыть файл";
            this.buttonFile_GTA.UseVisualStyleBackColor = true;
            this.buttonFile_GTA.Click += new System.EventHandler(this.buttonFile_GTA_Click);
            // 
            // buttonInfo_GTA
            // 
            this.buttonInfo_GTA.Location = new System.Drawing.Point(807, 12);
            this.buttonInfo_GTA.Name = "buttonInfo_GTA";
            this.buttonInfo_GTA.Size = new System.Drawing.Size(114, 70);
            this.buttonInfo_GTA.TabIndex = 3;
            this.buttonInfo_GTA.Text = "Справка";
            this.buttonInfo_GTA.UseVisualStyleBackColor = true;
            this.buttonInfo_GTA.Click += new System.EventHandler(this.buttonInfo_GTA_Click);
            // 
            // groupBoxOut_GTA
            // 
            this.groupBoxOut_GTA.Controls.Add(this.dataGridViewOut_GTA);
            this.groupBoxOut_GTA.Location = new System.Drawing.Point(13, 90);
            this.groupBoxOut_GTA.Name = "groupBoxOut_GTA";
            this.groupBoxOut_GTA.Size = new System.Drawing.Size(198, 417);
            this.groupBoxOut_GTA.TabIndex = 4;
            this.groupBoxOut_GTA.TabStop = false;
            this.groupBoxOut_GTA.Text = "Вывод данных:";
            // 
            // dataGridViewOut_GTA
            // 
            this.dataGridViewOut_GTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_GTA.ColumnHeadersVisible = false;
            this.dataGridViewOut_GTA.Location = new System.Drawing.Point(7, 23);
            this.dataGridViewOut_GTA.Name = "dataGridViewOut_GTA";
            this.dataGridViewOut_GTA.RowHeadersVisible = false;
            this.dataGridViewOut_GTA.Size = new System.Drawing.Size(184, 388);
            this.dataGridViewOut_GTA.TabIndex = 0;
            // 
            // chartDiagram_GTA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiagram_GTA.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDiagram_GTA.Legends.Add(legend4);
            this.chartDiagram_GTA.Location = new System.Drawing.Point(218, 90);
            this.chartDiagram_GTA.Name = "chartDiagram_GTA";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDiagram_GTA.Series.Add(series4);
            this.chartDiagram_GTA.Size = new System.Drawing.Size(703, 417);
            this.chartDiagram_GTA.TabIndex = 5;
            this.chartDiagram_GTA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.chartDiagram_GTA);
            this.Controls.Add(this.groupBoxOut_GTA);
            this.Controls.Add(this.buttonInfo_GTA);
            this.Controls.Add(this.buttonFile_GTA);
            this.Controls.Add(this.buttonDone_GTA);
            this.Controls.Add(this.groupBoxText_GTA);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Горнов Т. А.";
            this.groupBoxText_GTA.ResumeLayout(false);
            this.groupBoxText_GTA.PerformLayout();
            this.groupBoxOut_GTA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_GTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText_GTA;
        private System.Windows.Forms.Label labelText_GTA;
        private System.Windows.Forms.Button buttonDone_GTA;
        private System.Windows.Forms.Button buttonFile_GTA;
        private System.Windows.Forms.Button buttonInfo_GTA;
        private System.Windows.Forms.GroupBox groupBoxOut_GTA;
        private System.Windows.Forms.DataGridView dataGridViewOut_GTA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_GTA;
    }
}

