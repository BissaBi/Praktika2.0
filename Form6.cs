using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika2._0
{
    public partial class Form6 : Form
    {

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Закройте пожалуйста все открытые окна и нажмите на кнопку выхода на изначальном окне :) Cпасибо!!");
            this.Close();

        }
    }
}
