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

using Tyuiu.GornovTA.Sprint6.Task6.V29.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_GTA_Click(object sender, EventArgs e)
        {
            openFileDialogTaskSix_GTA.ShowDialog();
            openFilePath = openFileDialogTaskSix_GTA.FileName;
            textBoxIn_GTA.Text = File.ReadAllText(openFilePath);
            groupBoxIn_GTA.Text = groupBoxIn_GTA + " " + openFileDialogTaskSix_GTA.FileName;
            buttonDone_GTA.Enabled = true;
        }

        private void buttonDone_GTA_Click(object sender, EventArgs e)
        {
            textBoxOut_GTA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_GTA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы АСОиУб-23-2 Горнов Тимофей Анатольевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
