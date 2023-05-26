﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Praktika2._0
{
    public partial class Form1 : Form
    {

        private const string connectionString = "Server=194.169.163.175;Port=5432;Database=tsof;User Id=tsof;Password=123;";
        private const string query = "SELECT version FROM cur_vers";
        public string versiontxtfile;


        public Form1()
        {
            InitializeComponent();

            string versionFilePath = Path.Combine(Application.StartupPath, "version.txt");
            string versionshow = File.ReadAllText(versionFilePath);
            label2.Text = versionshow;

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
            FunctionTextBox.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FunctionTextBox.Text += "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FunctionTextBox.Text += "( )";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FunctionTextBox.Text += "√()";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FunctionTextBox.Text += "-";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FunctionTextBox.Text += "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FunctionTextBox.Text += "( / )";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FunctionTextBox.Text += "^";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FunctionTextBox.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            String func = FunctionTextBox.Text;

            List<string> arguments = new List<string>();
            string operand1 = "";
            string operand2 = "";
            string lastOperation = "";
            List<string> operations = new List<string> { "(", "+", "-", "*", "/", "^", ")", "(", "()" };
            List<string> functions = new List<string> { "sin", "cos", "exp", "tan", "ln", "lg", "sh", "ch" };

            int symbolNumber = 0;
            String sourceExpression = FunctionTextBox.Text.Replace(" ", "");

            while (symbolNumber < sourceExpression.Length)
            {
                int currentIndex = arguments.Count - 1;

                //Open brackets
                if (sourceExpression[symbolNumber] == '(')
                {
                    arguments.Add(sourceExpression[symbolNumber].ToString());
                    while (operations.Contains(arguments[currentIndex]) &&
                               operations.LastIndexOf(sourceExpression[symbolNumber].ToString()) >
                               operations.IndexOf(arguments[currentIndex]))
                    {
                        arguments[currentIndex + 1] = arguments[currentIndex];
                        currentIndex--;
                    }

                    arguments[currentIndex + 1] = sourceExpression[symbolNumber].ToString();
                    lastOperation = sourceExpression[symbolNumber].ToString();
                    symbolNumber++;
                    continue;
                }
                //Close brackets
                else if (sourceExpression[symbolNumber] == ')')
                {
                    arguments[arguments.LastIndexOf("(")] = "()";
                    lastOperation = "()";
                    symbolNumber++;
                    continue;
                }
                //Operation
                else if (operations.Contains(sourceExpression[symbolNumber].ToString()))
                {
                    //Always after (
                    if (lastOperation == "(")
                    {
                        int index = arguments.LastIndexOf(lastOperation);
                        arguments.Add(lastOperation);
                        while (currentIndex >= index)
                        {
                            arguments[currentIndex + 1] = arguments[currentIndex];
                            currentIndex--;
                        }

                        arguments[currentIndex + 1] = sourceExpression[symbolNumber].ToString();
                    }
                    //priority
                    else
                    {
                        arguments.Add(lastOperation.ToString());
                        while (
                            operations.Contains(arguments[currentIndex]) &&
                            operations.IndexOf(sourceExpression[symbolNumber].ToString()) >
                            operations.IndexOf(arguments[currentIndex]))
                        {
                            arguments[currentIndex + 1] = arguments[currentIndex];
                            currentIndex--;
                        }

                        arguments[currentIndex + 1] = sourceExpression[symbolNumber].ToString();
                    }

                    lastOperation = sourceExpression[symbolNumber].ToString();
                    symbolNumber++;
                }
                //Operand1
                else if (operand1 == "")
                {
                    while (symbolNumber < sourceExpression.Length &&
                        !operations.Contains(sourceExpression[symbolNumber].ToString()))
                    {
                        operand1 += sourceExpression[symbolNumber];
                        symbolNumber++;
                    }

                    arguments.Add(operand1);
                    if (functions.Contains(operand1))
                    {
                        arguments.Add("Compose");
                    }
                    operand2 = "";
                }
                //Operand2
                else if (operand2 == "")
                {
                    while (symbolNumber < sourceExpression.Length &&
                        !operations.Contains(sourceExpression[symbolNumber].ToString()))
                    {
                        operand2 += sourceExpression[symbolNumber];
                        symbolNumber++;
                    }

                    int index = arguments.LastIndexOf(lastOperation.ToString());
                    int bracketIndex = arguments.IndexOf("(");
                    if (bracketIndex > 0 &&
                        arguments.LastIndexOf(lastOperation.ToString(), bracketIndex) > 0 &&
                        arguments.LastIndexOf(lastOperation.ToString(), bracketIndex) < index)
                    {
                        index = arguments.LastIndexOf(lastOperation.ToString(), arguments.IndexOf("("));
                    }
                    arguments.Add(operand2);
                    if (functions.Contains(operand2))
                    {
                        arguments.Add("Compose");
                    }

                    #region Put arg2 at right place
                    currentIndex = arguments.Count - 1;
                    while (currentIndex > index)
                    {
                        if (functions.Contains(operand2))
                        {
                            arguments[currentIndex] = arguments[currentIndex - 2];
                        }
                        else
                        {
                            arguments[currentIndex] = arguments[currentIndex - 1];
                        }
                        currentIndex--;
                    }

                    arguments[index] = operand2;
                    if (functions.Contains(operand2))
                    {
                        arguments[index + 1] = "Compose";
                    }
                    #endregion

                    operand2 = "";
                }
                //ResultTextBox.Text += String.Join(",", arguments) + Environment.NewLine;
            }

            //ResultTextBox.Text = "";
            DiffTextBox.Text = String.Join(",", arguments);

            Dictionary<string, string> DiffsList = new Dictionary<string, string>();

            //Calculating f'
            while (arguments.Count > 1)
            {
                String firstOper = "";
                int firstOperIndex = arguments.Count;
                foreach (String str in operations)
                {
                    if (arguments.IndexOf(str) > 0 && arguments.IndexOf(str) < firstOperIndex)
                    {
                        firstOperIndex = arguments.IndexOf(str);
                        firstOper = str;
                    }
                }

                String f1 = "", f2 = "", df1 = "", df2 = "", oper = "", expression = "", diff = "";

                if (firstOper == "()")
                {
                    arguments.RemoveAt(firstOperIndex);
                    int ComposeIndex = arguments.LastIndexOf("Compose", firstOperIndex);
                    if (ComposeIndex > 0)
                    {
                        f1 = arguments[ComposeIndex - 1];
                        df1 = Proizv.Diff(f1, DiffsList);
                        f2 = arguments[ComposeIndex + 1];
                        df2 = Proizv.Diff(f2, DiffsList);
                        oper = "Compose";
                        expression = f1 + "(" + f2 + ")";
                        diff = Proizv.Diff(f1, df1, f2, df2, oper);

                        arguments.RemoveAt(ComposeIndex + 1);
                        arguments.RemoveAt(ComposeIndex);
                        arguments[ComposeIndex - 1] = expression;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    f1 = arguments[firstOperIndex - 2];
                    df1 = Proizv.Diff(f1, DiffsList);
                    f2 = arguments[firstOperIndex - 1];
                    df2 = Proizv.Diff(f2, DiffsList);
                    oper = arguments[firstOperIndex];
                    expression = f1 + oper + f2;
                    diff = Proizv.Diff(f1, df1, f2, df2, oper);

                    arguments.RemoveAt(firstOperIndex);
                    arguments.RemoveAt(firstOperIndex - 1);
                    arguments[firstOperIndex - 2] = expression;
                }

                //ResultTextBox.Text += Environment.NewLine + expression;
                DiffTextBox.Text += Environment.NewLine + diff;

                if (!DiffsList.ContainsKey(expression))
                {
                    DiffsList.Add(expression, diff);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            UpdateVersionFromDatabase();
        }

        private void UpdateVersionFromDatabase()
        {
            try
            {
                // Подключение к базе данных
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Запрос для получения значения из столбца app_version
                    string query = "SELECT version FROM cur_vers WHERE id = 1;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Получение значения из базы данных
                        string dbVersion = command.ExecuteScalar()?.ToString();

                        if (dbVersion != null)
                        {
                            // Чтение значения из файла version.txt
                            string versionFilePath = Path.Combine(Application.StartupPath, "version.txt");
                            string fileContent = File.ReadAllText(versionFilePath);

                            // Сравнение значения из базы данных и файла
                            if (dbVersion != fileContent)
                            {
                                // Обновление значения в файле
                                File.WriteAllText(versionFilePath, dbVersion);

                                // Присваивание нового значения переменной versionapptxt
                                versiontxtfile = dbVersion;

                                // Вывод сообщения об успешном обновлении
                                MessageBox.Show("Файл версии успешно обновлен.", "Успех");
                                Application.Restart();

                            }
                            else
                            {
                                MessageBox.Show("Значение версии в базе данных и файле уже совпадают.", "Информация");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Значение версии не найдено в базе данных.", "Ошибка");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении версии: " + ex.Message, "Ошибка");
            }
        }
    }

}
