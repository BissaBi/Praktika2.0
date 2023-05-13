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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21 f = new Form21();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 f = new Form22();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form23 f = new Form23();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 f = new Form24();
            f.ShowDialog();
        }
    }
}
