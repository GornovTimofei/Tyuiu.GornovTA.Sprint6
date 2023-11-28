
namespace Tyuiu.GornovTA.Sprint6.Task0.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lable1Start_GTA = new System.Windows.Forms.Label();
            this.lable2Text_GTA = new System.Windows.Forms.Label();
            this.pictureBoxFor_GTA = new System.Windows.Forms.PictureBox();
            this.lable3Medium_GTA = new System.Windows.Forms.Label();
            this.label4PerX_GTA = new System.Windows.Forms.Label();
            this.textBox1Per_GTA = new System.Windows.Forms.TextBox();
            this.label5Finish_GTA = new System.Windows.Forms.Label();
            this.label6TextRes_GTA = new System.Windows.Forms.Label();
            this.textBox2Res_GTA = new System.Windows.Forms.TextBox();
            this.buttonDone_GTA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFor_GTA)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1Start_GTA
            // 
            this.lable1Start_GTA.AutoSize = true;
            this.lable1Start_GTA.Location = new System.Drawing.Point(13, 13);
            this.lable1Start_GTA.Name = "lable1Start_GTA";
            this.lable1Start_GTA.Size = new System.Drawing.Size(51, 13);
            this.lable1Start_GTA.TabIndex = 0;
            this.lable1Start_GTA.Text = "Условие";
            // 
            // lable2Text_GTA
            // 
            this.lable2Text_GTA.AutoSize = true;
            this.lable2Text_GTA.Location = new System.Drawing.Point(13, 37);
            this.lable2Text_GTA.Name = "lable2Text_GTA";
            this.lable2Text_GTA.Size = new System.Drawing.Size(186, 13);
            this.lable2Text_GTA.TabIndex = 1;
            this.lable2Text_GTA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFor_GTA
            // 
            this.pictureBoxFor_GTA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFor_GTA.Image")));
            this.pictureBoxFor_GTA.Location = new System.Drawing.Point(363, 37);
            this.pictureBoxFor_GTA.Name = "pictureBoxFor_GTA";
            this.pictureBoxFor_GTA.Size = new System.Drawing.Size(113, 50);
            this.pictureBoxFor_GTA.TabIndex = 2;
            this.pictureBoxFor_GTA.TabStop = false;
            // 
            // lable3Medium_GTA
            // 
            this.lable3Medium_GTA.AutoSize = true;
            this.lable3Medium_GTA.Location = new System.Drawing.Point(13, 212);
            this.lable3Medium_GTA.Name = "lable3Medium_GTA";
            this.lable3Medium_GTA.Size = new System.Drawing.Size(72, 13);
            this.lable3Medium_GTA.TabIndex = 3;
            this.lable3Medium_GTA.Text = "Ввод данных";
            // 
            // label4PerX_GTA
            // 
            this.label4PerX_GTA.AutoSize = true;
            this.label4PerX_GTA.Location = new System.Drawing.Point(43, 241);
            this.label4PerX_GTA.Name = "label4PerX_GTA";
            this.label4PerX_GTA.Size = new System.Drawing.Size(75, 13);
            this.label4PerX_GTA.TabIndex = 4;
            this.label4PerX_GTA.Text = "Переменна X";
            // 
            // textBox1Per_GTA
            // 
            this.textBox1Per_GTA.Location = new System.Drawing.Point(30, 257);
            this.textBox1Per_GTA.Name = "textBox1Per_GTA";
            this.textBox1Per_GTA.Size = new System.Drawing.Size(100, 20);
            this.textBox1Per_GTA.TabIndex = 5;
            this.textBox1Per_GTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVar_KeyPress);
            // 
            // label5Finish_GTA
            // 
            this.label5Finish_GTA.AutoSize = true;
            this.label5Finish_GTA.Location = new System.Drawing.Point(279, 212);
            this.label5Finish_GTA.Name = "label5Finish_GTA";
            this.label5Finish_GTA.Size = new System.Drawing.Size(80, 13);
            this.label5Finish_GTA.TabIndex = 6;
            this.label5Finish_GTA.Text = "Вывод данных";
            // 
            // label6TextRes_GTA
            // 
            this.label6TextRes_GTA.AutoSize = true;
            this.label6TextRes_GTA.Location = new System.Drawing.Point(279, 241);
            this.label6TextRes_GTA.Name = "label6TextRes_GTA";
            this.label6TextRes_GTA.Size = new System.Drawing.Size(59, 13);
            this.label6TextRes_GTA.TabIndex = 7;
            this.label6TextRes_GTA.Text = "Результат";
            // 
            // textBox2Res_GTA
            // 
            this.textBox2Res_GTA.Location = new System.Drawing.Point(282, 257);
            this.textBox2Res_GTA.Name = "textBox2Res_GTA";
            this.textBox2Res_GTA.ReadOnly = true;
            this.textBox2Res_GTA.Size = new System.Drawing.Size(100, 20);
            this.textBox2Res_GTA.TabIndex = 8;
            // 
            // buttonDone_GTA
            // 
            this.buttonDone_GTA.Location = new System.Drawing.Point(363, 333);
            this.buttonDone_GTA.Name = "buttonDone_GTA";
            this.buttonDone_GTA.Size = new System.Drawing.Size(112, 37);
            this.buttonDone_GTA.TabIndex = 9;
            this.buttonDone_GTA.Text = "Выполнить";
            this.buttonDone_GTA.UseVisualStyleBackColor = true;
            this.buttonDone_GTA.Click += new System.EventHandler(this.buttonDone_GTA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 382);
            this.Controls.Add(this.buttonDone_GTA);
            this.Controls.Add(this.textBox2Res_GTA);
            this.Controls.Add(this.label6TextRes_GTA);
            this.Controls.Add(this.label5Finish_GTA);
            this.Controls.Add(this.textBox1Per_GTA);
            this.Controls.Add(this.label4PerX_GTA);
            this.Controls.Add(this.lable3Medium_GTA);
            this.Controls.Add(this.pictureBoxFor_GTA);
            this.Controls.Add(this.lable2Text_GTA);
            this.Controls.Add(this.lable1Start_GTA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Горнов Т.А.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFor_GTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1Start_GTA;
        private System.Windows.Forms.Label lable2Text_GTA;
        private System.Windows.Forms.PictureBox pictureBoxFor_GTA;
        private System.Windows.Forms.Label lable3Medium_GTA;
        private System.Windows.Forms.Label label4PerX_GTA;
        private System.Windows.Forms.TextBox textBox1Per_GTA;
        private System.Windows.Forms.Label label5Finish_GTA;
        private System.Windows.Forms.Label label6TextRes_GTA;
        private System.Windows.Forms.TextBox textBox2Res_GTA;
        private System.Windows.Forms.Button buttonDone_GTA;
    }
}

