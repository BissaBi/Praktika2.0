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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 f = new Form16();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 f = new Form17();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 f = new Form15();
            f.ShowDialog();
        }
    }
}
