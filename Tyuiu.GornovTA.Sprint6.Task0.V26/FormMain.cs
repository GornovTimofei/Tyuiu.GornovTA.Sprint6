using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.GornovTA.Sprint6.Task0.V26.Lib;

namespace Tyuiu.GornovTA.Sprint6.Task0.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_GTA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBox2Res_GTA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox1Per_GTA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
