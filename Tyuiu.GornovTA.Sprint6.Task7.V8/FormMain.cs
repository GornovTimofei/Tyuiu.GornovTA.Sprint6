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

using Tyuiu.GornovTA.Sprint6.Task7.V8.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task7.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTaskSeven_GTA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_GTA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        private int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_GTA_Click(object sender, EventArgs e)
        {
            openFileDialogTaskSeven_GTA.ShowDialog();
            openFilePath = openFileDialogTaskSeven_GTA.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn_GTA.ColumnCount = columns;
            dataGridViewIn_GTA.RowCount = rows;
            dataGridViewOut_GTA.ColumnCount = columns;
            dataGridViewOut_GTA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_GTA.Columns[i].Width = 30;
                dataGridViewOut_GTA.Columns[i].Width = 30;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_GTA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_GTA.Enabled = true;
        }

        private void buttonDone_GTA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_GTA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_GTA.Enabled = true;
        }

        private void buttonSaveFile_GTA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GTA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_GTA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GTA.ShowDialog();
            string path = saveFileDialogMatrix_GTA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_GTA.RowCount;
            int columns = dataGridViewOut_GTA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_GTA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_GTA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_GTA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент группы АСОиУб-23-2 Горнов Тимофей Анатольевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
