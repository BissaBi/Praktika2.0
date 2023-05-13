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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тема уже установлена!");
        }
    }
}
