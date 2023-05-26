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

        static class Program
        {
            /// <summary>
            /// Р“Р»Р°РІРЅР°СЏ С‚РѕС‡РєР° РІС…РѕРґР° РґР»СЏ РїСЂРёР»РѕР¶РµРЅРёСЏ.
            /// </summary>
            [STAThread]
            static void Main()
            {

            }
        }
        public class Constant
        {
            public static bool IsIt(String func)
            {
                try
                {
                    Convert.ToDouble(func);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static String Diff(String func)
            {
                return "0";
            }
        }
        public class Cosinus
        {
            public static bool IsIt(String func)
            {
                return (func == "cos");
            }

            public static String Diff(String func)
            {
                return "-sin";
            }
        }
        public class Exp
        {
            public static bool IsIt(String func)
            {
                return (func == "exp");
            }

            public static String Diff(String func)
            {
                return "exp";
            }
        }
        public class Monome
        {
            public static bool IsIt(String func)
            {
                if (func.Length > 2 && func.Substring(0, 2) == "x^")
                {
                    try
                    {
                        Convert.ToDouble(func.Substring(2));
                        return true;
                    }
                    catch (Exception) { }
                }

                return false;
            }

            public static String Diff(String func)
            {
                Double power = Convert.ToDouble(func.Substring(2));
                return power.ToString() + "*x^" + (power - 1).ToString();
            }
        }
        public class Sinus
        {
            public static bool IsIt(String func)
            {
                return (func == "sin");
            }

            public static String Diff(String func)
            {
                return "cos";
            }
        }
        public class X
        {
            public static bool IsIt(String func)
            {
                return (func == "x");
            }

            public static String Diff(String func)
            {
                return "1";
            }
        }
        public class Proizv
        {
            /// <summary>
            /// РР»РµРјРµРЅС‚Р°СЂРЅС‹Рµ РїСЂРѕРёР·РІРѕРґРЅС‹Рµ
            /// </summary>
            public static string Diff(String func)
            {
                String result = "";
                if (Constant.IsIt(func))
                {
                    result = Constant.Diff(func);
                }
                else if (X.IsIt(func))
                {
                    result = X.Diff(func);
                }
                else if (Monome.IsIt(func))
                {
                    result = Monome.Diff(func);
                }
                else if (Sinus.IsIt(func))
                {
                    result = Sinus.Diff(func);
                }
                else if (Cosinus.IsIt(func))
                {
                    result = Cosinus.Diff(func);
                }
                else if (Exp.IsIt(func))
                {
                    result = Exp.Diff(func);
                }

                return result;
            }

            public static string Diff(String func, Dictionary<string, string> DiffsList)
            {
                String dfunc = Diff(func);
                if (dfunc == "")
                {
                    foreach (KeyValuePair<string, string> pair in DiffsList)
                    {
                        if (pair.Key == func)
                        {
                            dfunc = pair.Value;
                        }
                    }
                }

                return dfunc;
            }

            public static string SimplifyMult(string func1, string func2)
            {
                String result = "(" + func1 + ")*(" + func2 + ")";
                if (func1 == "0" || func2 == "0")
                {
                    result = "0";
                }
                else if (func1 == "1")
                {
                    result = func2;
                }
                else if (func2 == "1")
                {
                    result = func1;
                }
                else if (Constant.IsIt(func1))
                {
                    result = func1 + "*(" + func2 + ")";
                }
                else if (Constant.IsIt(func2))
                {
                    result = func2 + "*(" + func1 + ")";
                }

                return result;
            }

            public static string SimplifyAdd(string func1, string func2, bool isAdd)
            {
                String result = "";
                if (func2 == "0")
                {
                    result = func1;
                }
                else if (func1 == "0")
                {
                    result = (isAdd) ? func2 : "-" + func2;
                }
                else
                {
                    result = (isAdd) ?
                        func1 + "+" + func2 :
                        func1 + "-" + func2;
                }

                return result;
            }

            /// <summary>
            /// РљРѕРјРїРѕР·РёС†РёРё
            /// </summary>
            public static String Diff(string func1, string dfunc1, string func2, string dfunc2, string oper)
            {
                String result = "";
                if (oper == "+")
                {
                    result = SimplifyAdd(dfunc1, dfunc2, true);
                }
                else if (oper == "-")
                {
                    result = SimplifyAdd(dfunc1, dfunc2, false);
                }
                else if (oper == "*")
                {
                    String result1 = SimplifyMult(func1, dfunc2);
                    String result2 = SimplifyMult(func2, dfunc1);
                    result = result1 + "+" + result2;
                }
                else if (oper == "/")
                {
                    result = "(" + SimplifyMult(func1, dfunc2) + "-" + SimplifyMult(func2, dfunc1) + ")/((" + func2 + ")^2)";
                }
                else if (oper == "^" && X.IsIt(func1) && Constant.IsIt(func2))
                {
                    result = Diff(func1 + "^" + func2);
                }
                else if (oper == "Compose")
                {
                    result = SimplifyMult(dfunc1 + "(" + func2 + ")", dfunc2);
                }

                return result;


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