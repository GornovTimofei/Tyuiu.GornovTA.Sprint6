
namespace Tyuiu.GornovTA.Sprint6.Task7.V8
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxText_GTA = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_GTA = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_GTA = new System.Windows.Forms.GroupBox();
            this.buttonOpenFile_GTA = new System.Windows.Forms.Button();
            this.buttonDone_GTA = new System.Windows.Forms.Button();
            this.buttonSaveFile_GTA = new System.Windows.Forms.Button();
            this.buttonInfo_GTA = new System.Windows.Forms.Button();
            this.labelText_GTA = new System.Windows.Forms.Label();
            this.dataGridViewIn_GTA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_GTA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTaskSeven_GTA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_GTA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButtons_GTA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxText_GTA.SuspendLayout();
            this.groupBoxIn_GTA.SuspendLayout();
            this.groupBoxOut_GTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GTA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxText_GTA
            // 
            this.groupBoxText_GTA.Controls.Add(this.labelText_GTA);
            this.groupBoxText_GTA.Location = new System.Drawing.Point(12, 74);
            this.groupBoxText_GTA.Name = "groupBoxText_GTA";
            this.groupBoxText_GTA.Size = new System.Drawing.Size(908, 78);
            this.groupBoxText_GTA.TabIndex = 0;
            this.groupBoxText_GTA.TabStop = false;
            this.groupBoxText_GTA.Text = "Условие";
            // 
            // groupBoxIn_GTA
            // 
            this.groupBoxIn_GTA.Controls.Add(this.dataGridViewIn_GTA);
            this.groupBoxIn_GTA.Location = new System.Drawing.Point(13, 158);
            this.groupBoxIn_GTA.Name = "groupBoxIn_GTA";
            this.groupBoxIn_GTA.Size = new System.Drawing.Size(458, 349);
            this.groupBoxIn_GTA.TabIndex = 1;
            this.groupBoxIn_GTA.TabStop = false;
            this.groupBoxIn_GTA.Text = "Ввод:";
            // 
            // groupBoxOut_GTA
            // 
            this.groupBoxOut_GTA.Controls.Add(this.dataGridViewOut_GTA);
            this.groupBoxOut_GTA.Location = new System.Drawing.Point(477, 158);
            this.groupBoxOut_GTA.Name = "groupBoxOut_GTA";
            this.groupBoxOut_GTA.Size = new System.Drawing.Size(444, 349);
            this.groupBoxOut_GTA.TabIndex = 2;
            this.groupBoxOut_GTA.TabStop = false;
            this.groupBoxOut_GTA.Text = "Вывод:";
            // 
            // buttonOpenFile_GTA
            // 
            this.buttonOpenFile_GTA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_GTA.Name = "buttonOpenFile_GTA";
            this.buttonOpenFile_GTA.Size = new System.Drawing.Size(80, 55);
            this.buttonOpenFile_GTA.TabIndex = 3;
            this.buttonOpenFile_GTA.Text = "Открыть файл";
            this.toolTipButtons_GTA.SetToolTip(this.buttonOpenFile_GTA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_GTA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GTA.Click += new System.EventHandler(this.buttonOpenFile_GTA_Click);
            // 
            // buttonDone_GTA
            // 
            this.buttonDone_GTA.Enabled = false;
            this.buttonDone_GTA.Location = new System.Drawing.Point(98, 12);
            this.buttonDone_GTA.Name = "buttonDone_GTA";
            this.buttonDone_GTA.Size = new System.Drawing.Size(80, 55);
            this.buttonDone_GTA.TabIndex = 4;
            this.buttonDone_GTA.Text = "Выполнить";
            this.toolTipButtons_GTA.SetToolTip(this.buttonDone_GTA, "Производит замены всех значений \r\nне равных 5 на -1 в 8 столбце");
            this.buttonDone_GTA.UseVisualStyleBackColor = true;
            this.buttonDone_GTA.Click += new System.EventHandler(this.buttonDone_GTA_Click);
            // 
            // buttonSaveFile_GTA
            // 
            this.buttonSaveFile_GTA.Enabled = false;
            this.buttonSaveFile_GTA.Location = new System.Drawing.Point(184, 12);
            this.buttonSaveFile_GTA.Name = "buttonSaveFile_GTA";
            this.buttonSaveFile_GTA.Size = new System.Drawing.Size(80, 55);
            this.buttonSaveFile_GTA.TabIndex = 5;
            this.buttonSaveFile_GTA.Text = "Сохранить";
            this.toolTipButtons_GTA.SetToolTip(this.buttonSaveFile_GTA, "Сохранить файл");
            this.buttonSaveFile_GTA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_GTA.Click += new System.EventHandler(this.buttonSaveFile_GTA_Click);
            // 
            // buttonInfo_GTA
            // 
            this.buttonInfo_GTA.Location = new System.Drawing.Point(841, 12);
            this.buttonInfo_GTA.Name = "buttonInfo_GTA";
            this.buttonInfo_GTA.Size = new System.Drawing.Size(80, 55);
            this.buttonInfo_GTA.TabIndex = 6;
            this.buttonInfo_GTA.Text = "Справка";
            this.toolTipButtons_GTA.SetToolTip(this.buttonInfo_GTA, "Сведение о программе");
            this.buttonInfo_GTA.UseVisualStyleBackColor = true;
            this.buttonInfo_GTA.Click += new System.EventHandler(this.buttonInfo_GTA_Click);
            // 
            // labelText_GTA
            // 
            this.labelText_GTA.AutoSize = true;
            this.labelText_GTA.Location = new System.Drawing.Point(7, 23);
            this.labelText_GTA.Name = "labelText_GTA";
            this.labelText_GTA.Size = new System.Drawing.Size(791, 45);
            this.labelText_GTA.TabIndex = 0;
            this.labelText_GTA.Text = resources.GetString("labelText_GTA.Text");
            // 
            // dataGridViewIn_GTA
            // 
            this.dataGridViewIn_GTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_GTA.ColumnHeadersVisible = false;
            this.dataGridViewIn_GTA.Location = new System.Drawing.Point(7, 23);
            this.dataGridViewIn_GTA.Name = "dataGridViewIn_GTA";
            this.dataGridViewIn_GTA.RowHeadersVisible = false;
            this.dataGridViewIn_GTA.Size = new System.Drawing.Size(445, 320);
            this.dataGridViewIn_GTA.TabIndex = 0;
            // 
            // dataGridViewOut_GTA
            // 
            this.dataGridViewOut_GTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_GTA.ColumnHeadersVisible = false;
            this.dataGridViewOut_GTA.Location = new System.Drawing.Point(7, 23);
            this.dataGridViewOut_GTA.Name = "dataGridViewOut_GTA";
            this.dataGridViewOut_GTA.RowHeadersVisible = false;
            this.dataGridViewOut_GTA.Size = new System.Drawing.Size(431, 320);
            this.dataGridViewOut_GTA.TabIndex = 0;
            // 
            // openFileDialogTaskSeven_GTA
            // 
            this.openFileDialogTaskSeven_GTA.FileName = "openFileDialog1";
            // 
            // toolTipButtons_GTA
            // 
            this.toolTipButtons_GTA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons_GTA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.buttonInfo_GTA);
            this.Controls.Add(this.buttonSaveFile_GTA);
            this.Controls.Add(this.buttonDone_GTA);
            this.Controls.Add(this.buttonOpenFile_GTA);
            this.Controls.Add(this.groupBoxOut_GTA);
            this.Controls.Add(this.groupBoxIn_GTA);
            this.Controls.Add(this.groupBoxText_GTA);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 8 | Горнов Т. А.";
            this.groupBoxText_GTA.ResumeLayout(false);
            this.groupBoxText_GTA.PerformLayout();
            this.groupBoxIn_GTA.ResumeLayout(false);
            this.groupBoxOut_GTA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText_GTA;
        private System.Windows.Forms.Label labelText_GTA;
        private System.Windows.Forms.GroupBox groupBoxIn_GTA;
        private System.Windows.Forms.DataGridView dataGridViewIn_GTA;
        private System.Windows.Forms.GroupBox groupBoxOut_GTA;
        private System.Windows.Forms.DataGridView dataGridViewOut_GTA;
        private System.Windows.Forms.Button buttonOpenFile_GTA;
        private System.Windows.Forms.Button buttonDone_GTA;
        private System.Windows.Forms.Button buttonSaveFile_GTA;
        private System.Windows.Forms.Button buttonInfo_GTA;
        private System.Windows.Forms.ToolTip toolTipButtons_GTA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTaskSeven_GTA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_GTA;
    }
}

