using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika2._0
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Закройте пожалуйста все открытые окна и нажмите на кнопку выхода на изначальном окне :) Cпасибо!!");
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле ввода пустое!");
            }
        }
    }
}
