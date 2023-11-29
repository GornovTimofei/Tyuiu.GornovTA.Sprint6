using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.GornovTA.Sprint6.Task1.V1.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInOne_GTA.Text);
                int stopStep = Convert.ToInt32(textBoxInTwo_GTA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxOut_GTA.Text = "";
                textBoxOut_GTA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxOut_GTA.AppendText("|     X     |   f(x)    |" + Environment.NewLine);
                textBoxOut_GTA.AppendText("+-----------+-----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |  {1,5:f2}    |", startStep, valueArray[i]);
                    textBoxOut_GTA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxOut_GTA.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void labelMedium1_GTA_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_GTA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Горнов Тимофей Анатольевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
