using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.GornovTA.Sprint6.Task3.V8.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task3.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -10, 10, -7, 19, 6 },
                { 15, -13, -19, 9, 1 },
                { -20, -15, -6, 8, -4 },
                { 10, 18, -5, 9, -6 },
                { 16, -10, 4, 15, 16 }, };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewIn_GTA.ColumnCount = columns;
            dataGridViewIn_GTA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_GTA.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_GTA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;
            dataGridViewOut_GTA.ColumnCount = columns;
            dataGridViewOut_GTA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewOut_GTA.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_GTA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonInfo_GTA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-2 Горнов Тимофей Анатольевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
