using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.GornovTA.Sprint6.Task4.V27.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task4.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_GTA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInStart_GTA.Text);
                int stopStep = Convert.ToInt32(textBoxInStop_GTA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_GTA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GTA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxOut_GTA.Text = "";
                chartFunction_GTA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_GTA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOut_GTA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_GTA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V27.txt";
                File.WriteAllText(path, textBoxOut_GTA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранение успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_GTA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-2 Горнов Тимофей Анатольевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
