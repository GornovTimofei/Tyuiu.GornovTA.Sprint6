
namespace Tyuiu.GornovTA.Sprint6.Task6.V29
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
            this.buttonInfo_GTA = new System.Windows.Forms.Button();
            this.labelText_GTA = new System.Windows.Forms.Label();
            this.textBoxIn_GTA = new System.Windows.Forms.TextBox();
            this.textBoxOut_GTA = new System.Windows.Forms.TextBox();
            this.openFileDialogTaskSix_GTA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTaskSix_GTA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxText_GTA.SuspendLayout();
            this.groupBoxIn_GTA.SuspendLayout();
            this.groupBoxOut_GTA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxText_GTA
            // 
            this.groupBoxText_GTA.Controls.Add(this.labelText_GTA);
            this.groupBoxText_GTA.Location = new System.Drawing.Point(12, 71);
            this.groupBoxText_GTA.Name = "groupBoxText_GTA";
            this.groupBoxText_GTA.Size = new System.Drawing.Size(909, 65);
            this.groupBoxText_GTA.TabIndex = 0;
            this.groupBoxText_GTA.TabStop = false;
            this.groupBoxText_GTA.Text = "Условие";
            // 
            // groupBoxIn_GTA
            // 
            this.groupBoxIn_GTA.Controls.Add(this.textBoxIn_GTA);
            this.groupBoxIn_GTA.Location = new System.Drawing.Point(12, 142);
            this.groupBoxIn_GTA.Name = "groupBoxIn_GTA";
            this.groupBoxIn_GTA.Size = new System.Drawing.Size(436, 365);
            this.groupBoxIn_GTA.TabIndex = 1;
            this.groupBoxIn_GTA.TabStop = false;
            this.groupBoxIn_GTA.Text = "Ввод:";
            // 
            // groupBoxOut_GTA
            // 
            this.groupBoxOut_GTA.Controls.Add(this.textBoxOut_GTA);
            this.groupBoxOut_GTA.Location = new System.Drawing.Point(454, 142);
            this.groupBoxOut_GTA.Name = "groupBoxOut_GTA";
            this.groupBoxOut_GTA.Size = new System.Drawing.Size(465, 365);
            this.groupBoxOut_GTA.TabIndex = 2;
            this.groupBoxOut_GTA.TabStop = false;
            this.groupBoxOut_GTA.Text = "Вывод:";
            // 
            // buttonOpenFile_GTA
            // 
            this.buttonOpenFile_GTA.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_GTA.Name = "buttonOpenFile_GTA";
            this.buttonOpenFile_GTA.Size = new System.Drawing.Size(107, 52);
            this.buttonOpenFile_GTA.TabIndex = 3;
            this.buttonOpenFile_GTA.Text = "Файл";
            this.toolTipTaskSix_GTA.SetToolTip(this.buttonOpenFile_GTA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_GTA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GTA.Click += new System.EventHandler(this.buttonOpenFile_GTA_Click);
            // 
            // buttonDone_GTA
            // 
            this.buttonDone_GTA.Enabled = false;
            this.buttonDone_GTA.Location = new System.Drawing.Point(126, 13);
            this.buttonDone_GTA.Name = "buttonDone_GTA";
            this.buttonDone_GTA.Size = new System.Drawing.Size(107, 52);
            this.buttonDone_GTA.TabIndex = 4;
            this.buttonDone_GTA.Text = "Выполнить";
            this.toolTipTaskSix_GTA.SetToolTip(this.buttonDone_GTA, "Производит поиск в файле\r\nи выводит слова в которых\r\nвстречается символ \"i\"\r\n");
            this.buttonDone_GTA.UseVisualStyleBackColor = true;
            this.buttonDone_GTA.Click += new System.EventHandler(this.buttonDone_GTA_Click);
            // 
            // buttonInfo_GTA
            // 
            this.buttonInfo_GTA.Location = new System.Drawing.Point(854, 13);
            this.buttonInfo_GTA.Name = "buttonInfo_GTA";
            this.buttonInfo_GTA.Size = new System.Drawing.Size(67, 52);
            this.buttonInfo_GTA.TabIndex = 5;
            this.buttonInfo_GTA.Text = "Справка";
            this.toolTipTaskSix_GTA.SetToolTip(this.buttonInfo_GTA, "Сведение о программе");
            this.buttonInfo_GTA.UseVisualStyleBackColor = true;
            this.buttonInfo_GTA.Click += new System.EventHandler(this.buttonInfo_GTA_Click);
            // 
            // labelText_GTA
            // 
            this.labelText_GTA.AutoSize = true;
            this.labelText_GTA.Location = new System.Drawing.Point(7, 23);
            this.labelText_GTA.Name = "labelText_GTA";
            this.labelText_GTA.Size = new System.Drawing.Size(784, 30);
            this.labelText_GTA.TabIndex = 0;
            this.labelText_GTA.Text = resources.GetString("labelText_GTA.Text");
            // 
            // textBoxIn_GTA
            // 
            this.textBoxIn_GTA.Location = new System.Drawing.Point(7, 23);
            this.textBoxIn_GTA.Multiline = true;
            this.textBoxIn_GTA.Name = "textBoxIn_GTA";
            this.textBoxIn_GTA.Size = new System.Drawing.Size(423, 336);
            this.textBoxIn_GTA.TabIndex = 0;
            // 
            // textBoxOut_GTA
            // 
            this.textBoxOut_GTA.Location = new System.Drawing.Point(7, 23);
            this.textBoxOut_GTA.Multiline = true;
            this.textBoxOut_GTA.Name = "textBoxOut_GTA";
            this.textBoxOut_GTA.Size = new System.Drawing.Size(452, 336);
            this.textBoxOut_GTA.TabIndex = 0;
            // 
            // openFileDialogTaskSix_GTA
            // 
            this.openFileDialogTaskSix_GTA.FileName = "openFileDialog1";
            // 
            // toolTipTaskSix_GTA
            // 
            this.toolTipTaskSix_GTA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTaskSix_GTA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.buttonInfo_GTA);
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
            this.Text = "Спринт 6 | Таск 6 | Вариант 29 | Горнов Т. А.";
            this.groupBoxText_GTA.ResumeLayout(false);
            this.groupBoxText_GTA.PerformLayout();
            this.groupBoxIn_GTA.ResumeLayout(false);
            this.groupBoxIn_GTA.PerformLayout();
            this.groupBoxOut_GTA.ResumeLayout(false);
            this.groupBoxOut_GTA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText_GTA;
        private System.Windows.Forms.Label labelText_GTA;
        private System.Windows.Forms.GroupBox groupBoxIn_GTA;
        private System.Windows.Forms.TextBox textBoxIn_GTA;
        private System.Windows.Forms.GroupBox groupBoxOut_GTA;
        private System.Windows.Forms.TextBox textBoxOut_GTA;
        private System.Windows.Forms.Button buttonOpenFile_GTA;
        private System.Windows.Forms.Button buttonDone_GTA;
        private System.Windows.Forms.Button buttonInfo_GTA;
        private System.Windows.Forms.ToolTip toolTipTaskSix_GTA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTaskSix_GTA;
    }
}

