
namespace Tyuiu.GornovTA.Sprint6.Task3.V8
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
            this.groupBoxIn_GTA = new System.Windows.Forms.GroupBox();
            this.labelIn_GTA = new System.Windows.Forms.Label();
            this.dataGridViewIn_GTA = new System.Windows.Forms.DataGridView();
            this.labelText_GTA = new System.Windows.Forms.Label();
            this.groupBoxOut_GTA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_GTA = new System.Windows.Forms.DataGridView();
            this.labelOut_GTA = new System.Windows.Forms.Label();
            this.buttonDone_GTA = new System.Windows.Forms.Button();
            this.buttonInfo_GTA = new System.Windows.Forms.Button();
            this.groupBoxIn_GTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GTA)).BeginInit();
            this.groupBoxOut_GTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GTA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIn_GTA
            // 
            this.groupBoxIn_GTA.Controls.Add(this.labelIn_GTA);
            this.groupBoxIn_GTA.Controls.Add(this.dataGridViewIn_GTA);
            this.groupBoxIn_GTA.Controls.Add(this.labelText_GTA);
            this.groupBoxIn_GTA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxIn_GTA.Name = "groupBoxIn_GTA";
            this.groupBoxIn_GTA.Size = new System.Drawing.Size(561, 416);
            this.groupBoxIn_GTA.TabIndex = 0;
            this.groupBoxIn_GTA.TabStop = false;
            this.groupBoxIn_GTA.Text = "Условие";
            // 
            // labelIn_GTA
            // 
            this.labelIn_GTA.AutoSize = true;
            this.labelIn_GTA.Location = new System.Drawing.Point(355, 19);
            this.labelIn_GTA.Name = "labelIn_GTA";
            this.labelIn_GTA.Size = new System.Drawing.Size(126, 15);
            this.labelIn_GTA.TabIndex = 2;
            this.labelIn_GTA.Text = "Исходная матрица:";
            // 
            // dataGridViewIn_GTA
            // 
            this.dataGridViewIn_GTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_GTA.ColumnHeadersVisible = false;
            this.dataGridViewIn_GTA.Location = new System.Drawing.Point(355, 37);
            this.dataGridViewIn_GTA.Name = "dataGridViewIn_GTA";
            this.dataGridViewIn_GTA.RowHeadersVisible = false;
            this.dataGridViewIn_GTA.Size = new System.Drawing.Size(200, 200);
            this.dataGridViewIn_GTA.TabIndex = 1;
            // 
            // labelText_GTA
            // 
            this.labelText_GTA.AutoSize = true;
            this.labelText_GTA.Location = new System.Drawing.Point(6, 19);
            this.labelText_GTA.Name = "labelText_GTA";
            this.labelText_GTA.Size = new System.Drawing.Size(175, 120);
            this.labelText_GTA.TabIndex = 0;
            this.labelText_GTA.Text = "Дана матрица 5 на 5\r\n-10  10  -7  19   6\r\n 15 -13 -19   9   1\r\n-20 -15  -6   8  -" +
    "4\r\n 10  18  -5   9  -6\r\n 16 -10   4  15  16\r\nЗаменить чётные элементы\r\nв четвёрт" +
    "ой строке на 0.";
            // 
            // groupBoxOut_GTA
            // 
            this.groupBoxOut_GTA.Controls.Add(this.dataGridViewOut_GTA);
            this.groupBoxOut_GTA.Controls.Add(this.labelOut_GTA);
            this.groupBoxOut_GTA.Location = new System.Drawing.Point(580, 13);
            this.groupBoxOut_GTA.Name = "groupBoxOut_GTA";
            this.groupBoxOut_GTA.Size = new System.Drawing.Size(212, 243);
            this.groupBoxOut_GTA.TabIndex = 1;
            this.groupBoxOut_GTA.TabStop = false;
            this.groupBoxOut_GTA.Text = "Вывод данных";
            // 
            // dataGridViewOut_GTA
            // 
            this.dataGridViewOut_GTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_GTA.ColumnHeadersVisible = false;
            this.dataGridViewOut_GTA.Location = new System.Drawing.Point(6, 37);
            this.dataGridViewOut_GTA.Name = "dataGridViewOut_GTA";
            this.dataGridViewOut_GTA.RowHeadersVisible = false;
            this.dataGridViewOut_GTA.Size = new System.Drawing.Size(200, 200);
            this.dataGridViewOut_GTA.TabIndex = 1;
            // 
            // labelOut_GTA
            // 
            this.labelOut_GTA.AutoSize = true;
            this.labelOut_GTA.Location = new System.Drawing.Point(6, 19);
            this.labelOut_GTA.Name = "labelOut_GTA";
            this.labelOut_GTA.Size = new System.Drawing.Size(77, 15);
            this.labelOut_GTA.TabIndex = 0;
            this.labelOut_GTA.Text = "Результат:";
            // 
            // buttonDone_GTA
            // 
            this.buttonDone_GTA.Location = new System.Drawing.Point(692, 394);
            this.buttonDone_GTA.Name = "buttonDone_GTA";
            this.buttonDone_GTA.Size = new System.Drawing.Size(100, 35);
            this.buttonDone_GTA.TabIndex = 3;
            this.buttonDone_GTA.Text = "Выполнить";
            this.buttonDone_GTA.UseVisualStyleBackColor = true;
            this.buttonDone_GTA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonInfo_GTA
            // 
            this.buttonInfo_GTA.Location = new System.Drawing.Point(580, 394);
            this.buttonInfo_GTA.Name = "buttonInfo_GTA";
            this.buttonInfo_GTA.Size = new System.Drawing.Size(35, 35);
            this.buttonInfo_GTA.TabIndex = 4;
            this.buttonInfo_GTA.Text = "?";
            this.buttonInfo_GTA.UseVisualStyleBackColor = true;
            this.buttonInfo_GTA.Click += new System.EventHandler(this.buttonInfo_GTA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.buttonInfo_GTA);
            this.Controls.Add(this.buttonDone_GTA);
            this.Controls.Add(this.groupBoxOut_GTA);
            this.Controls.Add(this.groupBoxIn_GTA);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 8 | Горнов Т. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxIn_GTA.ResumeLayout(false);
            this.groupBoxIn_GTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GTA)).EndInit();
            this.groupBoxOut_GTA.ResumeLayout(false);
            this.groupBoxOut_GTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIn_GTA;
        private System.Windows.Forms.DataGridView dataGridViewIn_GTA;
        private System.Windows.Forms.Label labelText_GTA;
        private System.Windows.Forms.Label labelIn_GTA;
        private System.Windows.Forms.GroupBox groupBoxOut_GTA;
        private System.Windows.Forms.DataGridView dataGridViewOut_GTA;
        private System.Windows.Forms.Label labelOut_GTA;
        private System.Windows.Forms.Button buttonDone_GTA;
        private System.Windows.Forms.Button buttonInfo_GTA;
    }
}

