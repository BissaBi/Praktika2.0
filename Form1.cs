namespace Praktika2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле ввода пустое!");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}