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
            foreach (Form f in Application.OpenForms)
                // спрячем все формы кроме основной
                if (f.GetType() != typeof(Form1))
                    f.Hide();

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                Application.ApplicationExit += delegate
                {
                    foreach (Form f in Application.OpenForms)
                        f.Close();
                };
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "( )";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√()";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "( / )";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
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
