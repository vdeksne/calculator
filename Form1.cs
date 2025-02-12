using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private TextBox lastFocusedTextBox;

        public Form1()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox_GotFocus;
            textBox2.GotFocus += TextBox_GotFocus;
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            lastFocusedTextBox = sender as TextBox;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                int c = a + b;
                label1.Text = c.ToString();
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                double c = Math.Pow(a, b);
                label1.Text = c.ToString();
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "1";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "2";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "3";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "4";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "5";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "6";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "7";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "8";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "9";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                lastFocusedTextBox.Text += "0";
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                label1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please focus on a text box to enter the number.");
            }
        }


        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                int c = a - b;
                label1.Text = c.ToString();
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                int c = a * b;
                label1.Text = c.ToString();
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (b != 0)
                {
                    int c = a / b;
                    label1.Text = c.ToString();
                }
                else
                {
                    label1.Text = "Cannot divide by zero";
                }
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBox1.Text, out a))
            {
                if (a >= 0)
                {
                    double c = Math.Sqrt(a);
                    label1.Text = c.ToString();
                }
                else
                {
                    label1.Text = "Cannot take square root of a negative number";
                }
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBox1.Text, out a))
            {
                double c = Math.Cos(a);
                label1.Text = c.ToString();
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBox1.Text, out a))
            {
                double c = Math.Sin(a);
                label1.Text = c.ToString();
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }
    }
}
