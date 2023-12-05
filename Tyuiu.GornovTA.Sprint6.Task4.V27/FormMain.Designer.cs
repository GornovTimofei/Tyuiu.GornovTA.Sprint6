
namespace Tyuiu.GornovTA.Sprint6.Task4.V27
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxText_GTA = new System.Windows.Forms.GroupBox();
            this.labelText_GTA = new System.Windows.Forms.Label();
            this.groupBoxIn_GTA = new System.Windows.Forms.GroupBox();
            this.textBoxInStop_GTA = new System.Windows.Forms.TextBox();
            this.textBoxInStart_GTA = new System.Windows.Forms.TextBox();
            this.labelInStop_GTA = new System.Windows.Forms.Label();
            this.labelInStart_GTA = new System.Windows.Forms.Label();
            this.buttonDone_GTA = new System.Windows.Forms.Button();
            this.buttonSave_GTA = new System.Windows.Forms.Button();
            this.buttonHelp_GTA = new System.Windows.Forms.Button();
            this.groupBoxOut_GTA = new System.Windows.Forms.GroupBox();
            this.textBoxOut_GTA = new System.Windows.Forms.TextBox();
            this.chartFunction_GTA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxText_GTA.SuspendLayout();
            this.groupBoxIn_GTA.SuspendLayout();
            this.groupBoxOut_GTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GTA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxText_GTA
            // 
            this.groupBoxText_GTA.Controls.Add(this.labelText_GTA);
            this.groupBoxText_GTA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxText_GTA.Name = "groupBoxText_GTA";
            this.groupBoxText_GTA.Size = new System.Drawing.Size(427, 77);
            this.groupBoxText_GTA.TabIndex = 0;
            this.groupBoxText_GTA.TabStop = false;
            this.groupBoxText_GTA.Text = "Условие";
            // 
            // labelText_GTA
            // 
            this.labelText_GTA.AutoSize = true;
            this.labelText_GTA.Location = new System.Drawing.Point(7, 23);
            this.labelText_GTA.Name = "labelText_GTA";
            this.labelText_GTA.Size = new System.Drawing.Size(413, 45);
            this.labelText_GTA.TabIndex = 0;
            this.labelText_GTA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и \r\nсохранить в файл OutPutFileTask4V27.txt по н" +
    "ажатию кнопки.";
            // 
            // groupBoxIn_GTA
            // 
            this.groupBoxIn_GTA.Controls.Add(this.textBoxInStop_GTA);
            this.groupBoxIn_GTA.Controls.Add(this.textBoxInStart_GTA);
            this.groupBoxIn_GTA.Controls.Add(this.labelInStop_GTA);
            this.groupBoxIn_GTA.Controls.Add(this.labelInStart_GTA);
            this.groupBoxIn_GTA.Location = new System.Drawing.Point(446, 13);
            this.groupBoxIn_GTA.Name = "groupBoxIn_GTA";
            this.groupBoxIn_GTA.Size = new System.Drawing.Size(219, 77);
            this.groupBoxIn_GTA.TabIndex = 1;
            this.groupBoxIn_GTA.TabStop = false;
            this.groupBoxIn_GTA.Text = "Ввод данных";
            // 
            // textBoxInStop_GTA
            // 
            this.textBoxInStop_GTA.Location = new System.Drawing.Point(113, 42);
            this.textBoxInStop_GTA.Name = "textBoxInStop_GTA";
            this.textBoxInStop_GTA.Size = new System.Drawing.Size(100, 23);
            this.textBoxInStop_GTA.TabIndex = 4;
            // 
            // textBoxInStart_GTA
            // 
            this.textBoxInStart_GTA.Location = new System.Drawing.Point(7, 42);
            this.textBoxInStart_GTA.Name = "textBoxInStart_GTA";
            this.textBoxInStart_GTA.Size = new System.Drawing.Size(100, 23);
            this.textBoxInStart_GTA.TabIndex = 3;
            // 
            // labelInStop_GTA
            // 
            this.labelInStop_GTA.AutoSize = true;
            this.labelInStop_GTA.Location = new System.Drawing.Point(110, 23);
            this.labelInStop_GTA.Name = "labelInStop_GTA";
            this.labelInStop_GTA.Size = new System.Drawing.Size(84, 15);
            this.labelInStop_GTA.TabIndex = 2;
            this.labelInStop_GTA.Text = "Конец шага:";
            // 
            // labelInStart_GTA
            // 
            this.labelInStart_GTA.AutoSize = true;
            this.labelInStart_GTA.Location = new System.Drawing.Point(7, 23);
            this.labelInStart_GTA.Name = "labelInStart_GTA";
            this.labelInStart_GTA.Size = new System.Drawing.Size(84, 15);
            this.labelInStart_GTA.TabIndex = 0;
            this.labelInStart_GTA.Text = "Старт шага:";
            // 
            // buttonDone_GTA
            // 
            this.buttonDone_GTA.Location = new System.Drawing.Point(671, 12);
            this.buttonDone_GTA.Name = "buttonDone_GTA";
            this.buttonDone_GTA.Size = new System.Drawing.Size(78, 77);
            this.buttonDone_GTA.TabIndex = 2;
            this.buttonDone_GTA.Text = "Выполнить";
            this.buttonDone_GTA.UseVisualStyleBackColor = true;
            this.buttonDone_GTA.Click += new System.EventHandler(this.buttonDone_GTA_Click);
            // 
            // buttonSave_GTA
            // 
            this.buttonSave_GTA.Location = new System.Drawing.Point(755, 13);
            this.buttonSave_GTA.Name = "buttonSave_GTA";
            this.buttonSave_GTA.Size = new System.Drawing.Size(79, 77);
            this.buttonSave_GTA.TabIndex = 3;
            this.buttonSave_GTA.Text = "Сохранить";
            this.buttonSave_GTA.UseVisualStyleBackColor = true;
            this.buttonSave_GTA.Click += new System.EventHandler(this.buttonSave_GTA_Click);
            // 
            // buttonHelp_GTA
            // 
            this.buttonHelp_GTA.Location = new System.Drawing.Point(840, 13);
            this.buttonHelp_GTA.Name = "buttonHelp_GTA";
            this.buttonHelp_GTA.Size = new System.Drawing.Size(77, 77);
            this.buttonHelp_GTA.TabIndex = 4;
            this.buttonHelp_GTA.Text = "Справка";
            this.buttonHelp_GTA.UseVisualStyleBackColor = true;
            this.buttonHelp_GTA.Click += new System.EventHandler(this.buttonHelp_GTA_Click);
            // 
            // groupBoxOut_GTA
            // 
            this.groupBoxOut_GTA.Controls.Add(this.textBoxOut_GTA);
            this.groupBoxOut_GTA.Location = new System.Drawing.Point(13, 97);
            this.groupBoxOut_GTA.Name = "groupBoxOut_GTA";
            this.groupBoxOut_GTA.Size = new System.Drawing.Size(238, 410);
            this.groupBoxOut_GTA.TabIndex = 5;
            this.groupBoxOut_GTA.TabStop = false;
            this.groupBoxOut_GTA.Text = "Вывод данных";
            // 
            // textBoxOut_GTA
            // 
            this.textBoxOut_GTA.Location = new System.Drawing.Point(7, 23);
            this.textBoxOut_GTA.Multiline = true;
            this.textBoxOut_GTA.Name = "textBoxOut_GTA";
            this.textBoxOut_GTA.Size = new System.Drawing.Size(225, 381);
            this.textBoxOut_GTA.TabIndex = 0;
            // 
            // chartFunction_GTA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_GTA.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_GTA.Legends.Add(legend5);
            this.chartFunction_GTA.Location = new System.Drawing.Point(258, 97);
            this.chartFunction_GTA.Name = "chartFunction_GTA";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_GTA.Series.Add(series5);
            this.chartFunction_GTA.Size = new System.Drawing.Size(663, 410);
            this.chartFunction_GTA.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.chartFunction_GTA);
            this.Controls.Add(this.groupBoxOut_GTA);
            this.Controls.Add(this.buttonHelp_GTA);
            this.Controls.Add(this.buttonSave_GTA);
            this.Controls.Add(this.buttonDone_GTA);
            this.Controls.Add(this.groupBoxIn_GTA);
            this.Controls.Add(this.groupBoxText_GTA);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 27 | Горнов Т. А.";
            this.groupBoxText_GTA.ResumeLayout(false);
            this.groupBoxText_GTA.PerformLayout();
            this.groupBoxIn_GTA.ResumeLayout(false);
            this.groupBoxIn_GTA.PerformLayout();
            this.groupBoxOut_GTA.ResumeLayout(false);
            this.groupBoxOut_GTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText_GTA;
        private System.Windows.Forms.Label labelText_GTA;
        private System.Windows.Forms.GroupBox groupBoxIn_GTA;
        private System.Windows.Forms.TextBox textBoxInStop_GTA;
        private System.Windows.Forms.TextBox textBoxInStart_GTA;
        private System.Windows.Forms.Label labelInStop_GTA;
        private System.Windows.Forms.Label labelInStart_GTA;
        private System.Windows.Forms.Button buttonDone_GTA;
        private System.Windows.Forms.Button buttonSave_GTA;
        private System.Windows.Forms.Button buttonHelp_GTA;
        private System.Windows.Forms.GroupBox groupBoxOut_GTA;
        private System.Windows.Forms.TextBox textBoxOut_GTA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GTA;
    }
}

