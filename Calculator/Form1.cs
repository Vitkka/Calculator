using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int num_0 = 0;
        int num_1 = 1;
        int num_2 = 2;
        int num_3 = 3;
        int num_4 = 4;
        int num_5 = 5;
        int num_6 = 6;
        int num_7 = 7;
        int num_8 = 8;
        int num_9 = 9;
        string input = "0";
        public void SQRT(string input)
        {
            double value;
            Double.TryParse(input, out value);
            Math.Sqrt(value);
            textBox1.Text = value.ToString();
        }

        public void POW(string input)
        {

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_1.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_2.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_3.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_4.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_5.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_6.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_7.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_8.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_9.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            double result = 0;

            // Проверяем, содержит ли выражение символы +, -, *, /
            if (expression.Contains("+"))
            {
                string[] numbers = expression.Split('+');
                result = Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1]);
            }
            else if (expression.Contains("-"))
            {
                string[] numbers = expression.Split('-');
                result = Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1]);
            }
            else if (expression.Contains("*"))
            {
                string[] numbers = expression.Split('*');
                result = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
            }
            else if (expression.Contains("/"))
            {
                string[] numbers = expression.Split('/');
                result = Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);
            }

            textBox1.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += num_0.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = textBox1.Text;
            SQRT(input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input = textBox1.Text;
            POW(input);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
