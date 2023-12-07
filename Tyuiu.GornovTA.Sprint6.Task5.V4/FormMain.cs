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

using Tyuiu.GornovTA.Sprint6.Task5.V4.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Admin\source\repos\Tyuiu.GornovTA.Sprint6\Tyuiu.GornovTA.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";

        private void buttonDone_GTA_Click(object sender, EventArgs e)
        {
            dataGridViewOut_GTA.ColumnCount = 2;
            dataGridViewOut_GTA.Columns[0].Width = 30;
            dataGridViewOut_GTA.Columns[1].Width = 50;
            this.chartDiagram_GTA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagram_GTA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDiagram_GTA.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewOut_GTA.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartDiagram_GTA.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonFile_GTA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_GTA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-2 Горнов Тимофей Анатольевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
