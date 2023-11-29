
namespace Tyuiu.GornovTA.Sprint6.Task1.V1
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
            this.labelStart1_GTA = new System.Windows.Forms.Label();
            this.labelMedium1_GTA = new System.Windows.Forms.Label();
            this.labelInText_GTA = new System.Windows.Forms.Label();
            this.labelInTwo_GTA = new System.Windows.Forms.Label();
            this.textBoxInOne_GTA = new System.Windows.Forms.TextBox();
            this.textBoxInTwo_GTA = new System.Windows.Forms.TextBox();
            this.labelInOne_GTA = new System.Windows.Forms.Label();
            this.buttonFinish_GTA = new System.Windows.Forms.Button();
            this.buttonHelp_GTA = new System.Windows.Forms.Button();
            this.labelOutText1_GTA = new System.Windows.Forms.Label();
            this.labelOutText2_GTA = new System.Windows.Forms.Label();
            this.textBoxOut_GTA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelStart1_GTA
            // 
            this.labelStart1_GTA.AutoSize = true;
            this.labelStart1_GTA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart1_GTA.Location = new System.Drawing.Point(12, 9);
            this.labelStart1_GTA.Name = "labelStart1_GTA";
            this.labelStart1_GTA.Size = new System.Drawing.Size(56, 15);
            this.labelStart1_GTA.TabIndex = 0;
            this.labelStart1_GTA.Text = "Условие";
            // 
            // labelMedium1_GTA
            // 
            this.labelMedium1_GTA.AutoSize = true;
            this.labelMedium1_GTA.Location = new System.Drawing.Point(12, 34);
            this.labelMedium1_GTA.Name = "labelMedium1_GTA";
            this.labelMedium1_GTA.Size = new System.Drawing.Size(329, 60);
            this.labelMedium1_GTA.TabIndex = 1;
            this.labelMedium1_GTA.Text = "Протабулировать функцию на заданном диапазоне.\r\nf(x)=cos(2x)+ (sin(2x))/(x+2,5))+" +
    "2x \r\n\r\nРезультат вывести в виде таблицы.";
            this.labelMedium1_GTA.Click += new System.EventHandler(this.labelMedium1_GTA_Click);
            // 
            // labelInText_GTA
            // 
            this.labelInText_GTA.AutoSize = true;
            this.labelInText_GTA.Location = new System.Drawing.Point(12, 332);
            this.labelInText_GTA.Name = "labelInText_GTA";
            this.labelInText_GTA.Size = new System.Drawing.Size(91, 15);
            this.labelInText_GTA.TabIndex = 2;
            this.labelInText_GTA.Text = "Ввод данных:";
            this.labelInText_GTA.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelInTwo_GTA
            // 
            this.labelInTwo_GTA.AutoSize = true;
            this.labelInTwo_GTA.Location = new System.Drawing.Point(116, 347);
            this.labelInTwo_GTA.Name = "labelInTwo_GTA";
            this.labelInTwo_GTA.Size = new System.Drawing.Size(84, 15);
            this.labelInTwo_GTA.TabIndex = 3;
            this.labelInTwo_GTA.Text = "Конец щага:";
            // 
            // textBoxInOne_GTA
            // 
            this.textBoxInOne_GTA.Location = new System.Drawing.Point(13, 365);
            this.textBoxInOne_GTA.Name = "textBoxInOne_GTA";
            this.textBoxInOne_GTA.Size = new System.Drawing.Size(100, 23);
            this.textBoxInOne_GTA.TabIndex = 4;
            // 
            // textBoxInTwo_GTA
            // 
            this.textBoxInTwo_GTA.Location = new System.Drawing.Point(119, 365);
            this.textBoxInTwo_GTA.Name = "textBoxInTwo_GTA";
            this.textBoxInTwo_GTA.Size = new System.Drawing.Size(100, 23);
            this.textBoxInTwo_GTA.TabIndex = 5;
            // 
            // labelInOne_GTA
            // 
            this.labelInOne_GTA.AutoSize = true;
            this.labelInOne_GTA.Location = new System.Drawing.Point(12, 347);
            this.labelInOne_GTA.Name = "labelInOne_GTA";
            this.labelInOne_GTA.Size = new System.Drawing.Size(84, 15);
            this.labelInOne_GTA.TabIndex = 6;
            this.labelInOne_GTA.Text = "Старт шага:";
            this.labelInOne_GTA.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonFinish_GTA
            // 
            this.buttonFinish_GTA.Location = new System.Drawing.Point(301, 347);
            this.buttonFinish_GTA.Name = "buttonFinish_GTA";
            this.buttonFinish_GTA.Size = new System.Drawing.Size(89, 41);
            this.buttonFinish_GTA.TabIndex = 7;
            this.buttonFinish_GTA.Text = "Выполнить";
            this.buttonFinish_GTA.UseVisualStyleBackColor = true;
            this.buttonFinish_GTA.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHelp_GTA
            // 
            this.buttonHelp_GTA.Location = new System.Drawing.Point(225, 347);
            this.buttonHelp_GTA.Name = "buttonHelp_GTA";
            this.buttonHelp_GTA.Size = new System.Drawing.Size(70, 41);
            this.buttonHelp_GTA.TabIndex = 8;
            this.buttonHelp_GTA.Text = "Справка";
            this.buttonHelp_GTA.UseVisualStyleBackColor = true;
            this.buttonHelp_GTA.Click += new System.EventHandler(this.buttonHelp_GTA_Click);
            // 
            // labelOutText1_GTA
            // 
            this.labelOutText1_GTA.AutoSize = true;
            this.labelOutText1_GTA.Location = new System.Drawing.Point(401, 34);
            this.labelOutText1_GTA.Name = "labelOutText1_GTA";
            this.labelOutText1_GTA.Size = new System.Drawing.Size(98, 15);
            this.labelOutText1_GTA.TabIndex = 9;
            this.labelOutText1_GTA.Text = "Вывод данных:";
            // 
            // labelOutText2_GTA
            // 
            this.labelOutText2_GTA.AutoSize = true;
            this.labelOutText2_GTA.Location = new System.Drawing.Point(401, 49);
            this.labelOutText2_GTA.Name = "labelOutText2_GTA";
            this.labelOutText2_GTA.Size = new System.Drawing.Size(77, 15);
            this.labelOutText2_GTA.TabIndex = 10;
            this.labelOutText2_GTA.Text = "Результат:";
            // 
            // textBoxOut_GTA
            // 
            this.textBoxOut_GTA.Location = new System.Drawing.Point(404, 67);
            this.textBoxOut_GTA.Multiline = true;
            this.textBoxOut_GTA.Name = "textBoxOut_GTA";
            this.textBoxOut_GTA.ReadOnly = true;
            this.textBoxOut_GTA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_GTA.Size = new System.Drawing.Size(224, 321);
            this.textBoxOut_GTA.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 397);
            this.Controls.Add(this.textBoxOut_GTA);
            this.Controls.Add(this.labelOutText2_GTA);
            this.Controls.Add(this.labelOutText1_GTA);
            this.Controls.Add(this.buttonHelp_GTA);
            this.Controls.Add(this.buttonFinish_GTA);
            this.Controls.Add(this.labelInOne_GTA);
            this.Controls.Add(this.textBoxInTwo_GTA);
            this.Controls.Add(this.textBoxInOne_GTA);
            this.Controls.Add(this.labelInTwo_GTA);
            this.Controls.Add(this.labelInText_GTA);
            this.Controls.Add(this.labelMedium1_GTA);
            this.Controls.Add(this.labelStart1_GTA);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 1 | Горнов Т.А.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStart1_GTA;
        private System.Windows.Forms.Label labelMedium1_GTA;
        private System.Windows.Forms.Label labelInText_GTA;
        private System.Windows.Forms.Label labelInTwo_GTA;
        private System.Windows.Forms.TextBox textBoxInOne_GTA;
        private System.Windows.Forms.TextBox textBoxInTwo_GTA;
        private System.Windows.Forms.Label labelInOne_GTA;
        private System.Windows.Forms.Button buttonFinish_GTA;
        private System.Windows.Forms.Button buttonHelp_GTA;
        private System.Windows.Forms.Label labelOutText1_GTA;
        private System.Windows.Forms.Label labelOutText2_GTA;
        private System.Windows.Forms.TextBox textBoxOut_GTA;
    }
}

